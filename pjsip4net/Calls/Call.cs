using System;
using Common.Logging;
using pjsip4net.Accounts;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls
{
    internal class Call : Initializable, ICall, IMediaSource, IIdentifiable<ICall>
    {
        #region Private data

        private readonly MediaSession _mediaSession;
        private readonly ICallManagerInternal _callManager;
        private Account _account;
        private IDisposable _accountLock;
        private readonly SignallingSession _signallingSession;
        private readonly ILog _logger = LogManager.GetLogger<ICall>();
        private CallInfo _cachedInfo;

        #endregion

        #region Properties

        private string _destinationUri;

        public IAccount Account
        {
            get
            {
                return _account;
            }
        }

        public string DestinationUri
        {
            get
            {
                return _destinationUri;
            }
            internal set
            {
                GuardDisposed();
                GuardNotInitializing();
                _destinationUri = value;
            }
        }

        public InviteState InviteState
        {
            get { return _signallingSession.InviteState; }
        }

        public CallMediaState MediaState
        {
            get { return _mediaSession.MediaState; }
        }

        public virtual bool IsIncoming { get; private set; }

        public virtual bool IsActive
        {
            get
            {
                return Id != -1 &&
                       _callManager.CallApiProvider.IsCallActive(Id);
            }
        }

        public bool HasMedia
        {
            get
            {
                return Id != -1 && _callManager.CallApiProvider.CallHasMedia(Id) &&
                       _mediaSession.IsActive;
            }
        }

        public string LocalInfo
        {
            get
            {
                var info = GetCallInfo();
                return info.LocalInfo;
            }
        }

        public string LocalContact
        {
            get
            {
                var info = GetCallInfo();
                return info.LocalContact;
            }
        }

        public string RemoteInfo
        {
            get
            {
                var info = GetCallInfo();
                return info.RemoteInfo;
            }
        }

        public string RemoteContact
        {
            get
            {
                var info = GetCallInfo();
                return info.RemoteContact;
            }
        }

        public string DialogId
        {
            get
            {
                var info = GetCallInfo();
                return info.CallId;
            }
        }

        public string StateText
        {
            get
            {
                var info = GetCallInfo();
                return info.StateText;
            }
        }

        public SipStatusCode LastStatusCode
        {
            get
            {
                var info = GetCallInfo();
                return info.LastStatus;
            }
        }

        public string LastStatusText
        {
            get
            {
                var info = GetCallInfo();
                return info.LastStatusText;
            }
        }

        public int ConferenceSlotId
        {
            get
            {
                GuardDisposed();
                return GetCallInfo().ConfSlot;
            }
        }

        public double RxLevel
        {
            get
            {
                var level = _callManager.MediaApiProvider.GetSignalLevel(ConferenceSlotId);
                return level.Rx/255.0;
            }
            set
            {
                GuardDisposed();
                Helper.GuardInRange(0.0d, 1.0d, value);
                _callManager.MediaApiProvider.AdjustRxLevel(ConferenceSlotId, (float) value);
            }
        }

        public double TxLevel
        {
            get
            {
                var level = _callManager.MediaApiProvider.GetSignalLevel(ConferenceSlotId);
                return level.Tx / 255.0;
            }
            set
            {
                GuardDisposed();
                Helper.GuardInRange(0.0d, 1.0d, value);
                _callManager.MediaApiProvider.AdjustTxLevel(ConferenceSlotId, (float) value);
            }
        }

        public TimeSpan ConnectDuration
        {
            get
            {
                var info = GetCallInfo();
                return info.ConnectDuration;
            }
        }

        public TimeSpan TotalDuration
        {
            get
            {
                var info = GetCallInfo();
                return info.TotalDuration;
            }
        }

        public int Id { get; internal set; }
        
        public SignallingSession InviteSession
        {
            get { return _signallingSession; }
        }

        public MediaSession MediaSession
        {
            get { return _mediaSession; }
        }

        #endregion

        #region Methods

        public Call(ICallManagerInternal callManager, IRegistry registry, IConferenceBridge conferenceBridge)
        {
            Id = -1;
            Helper.GuardNotNull(callManager);
            Helper.GuardNotNull(conferenceBridge);
            Helper.GuardNotNull(registry);
            _callManager = callManager;

            _signallingSession = new SignallingSession(this, callManager);
            _signallingSession.StateChanged += delegate { OnStateChanged(); };
            _mediaSession = new MediaSession(this, registry, callManager, conferenceBridge);
            _mediaSession.StateChanged += delegate { OnStateChanged(); };

            CallInfo info = GetCallInfo();//TODO: move to inviteSession
            if (info != null) 
                IsIncoming = info.Role == SipRole.RoleUas;
        }

        public override void BeginInit()
        {
            GuardInitialized();
            base.BeginInit();
        }

        public override void EndInit()
        {
            GuardNotInitializing();
            base.EndInit();
            if (!IsIncoming)
                Helper.GuardIsTrue(new SipUriParser(DestinationUri).IsValid);

            _accountLock = _account.Lock(); //if everything is ok
        }

        public void Hold()
        {
            GuardDisposed();
            if (_signallingSession.IsConfirmed && IsActive)
                _callManager.CallApiProvider.PutCallOnHold(Id);
        }

        public void ReleaseHold()
        {
            GuardDisposed();
            if (_mediaSession.IsHeld) // media state should reflect correct state
                _callManager.CallApiProvider.ReinviteCall(Id, true);
        }

        public void Transfer(string destinationUri)
        {
            GuardDisposed();
            Helper.GuardNotNullStr(destinationUri);
            Helper.GuardIsTrue(new SipUriParser(destinationUri).IsValid);
            if (_mediaSession.IsActive || this._mediaSession.MediaState == CallMediaState.None)
                _callManager.CallApiProvider.TransferCall(Id, destinationUri);
        }

        public void Hangup()
        {
            Hangup(string.Empty);
        }

        public void Hangup(string reason)
        {
            GuardDisposed();
            _mediaSession.Dispose();
            if (!_signallingSession.IsDisconnected)
                _callManager.CallApiProvider.HangupCall(Id, SipStatusCode.Decline, reason);
        }

        public void Answer(bool accept)
        {
            Answer(accept, string.Empty);
        }

        public void Answer(bool accept, string reason)
        {
            GuardDisposed();
            if (!IsIncoming)
                throw new InvalidOperationException("Can not answer on outgoing call");

            if (!_signallingSession.IsConfirmed)
            {
                var code = (accept
                                ? SipStatusCode.Ok
                                : SipStatusCode.Decline);
                _callManager.CallApiProvider.AnswerCall(Id, code, reason);
            }
        }

        public void ConnectToConference()
        {
            GuardDisposed();
            if (!_mediaSession.IsInConference)
                _mediaSession.ConnectToConference();
        }

        public void DisconnectFromConference()
        {
            GuardDisposed();
            if (_mediaSession.IsInConference)
                _mediaSession.DisconnectFromConference();
        }

        public void SendDtmf(string digits)
        {
            GuardDisposed();
            if (IsActive)
                _callManager.CallApiProvider.DialDtmf(Id, digits);
        }

        public void SetId(int id)
        {
            GuardDisposed();
            Helper.GuardPositiveInt(id);
            Id = id;
        }

        public void SetDestinationUri(string uri)
        {
            GuardDisposed();
            Helper.GuardNotNullStr(uri);
            DestinationUri = uri;
        }

        public void SetAccount(Account account)
        {
            GuardDisposed();
            Helper.GuardNotNull(account);
            _account = account;
            if (IsIncoming)
                _accountLock = _account.Lock();
        }

        public void SetAsIncoming()
        {
            GuardDisposed();
            IsIncoming = true;
        }

        public virtual CallInfo GetCallInfo()
        {
            if (_isDisposed)
                return _cachedInfo;

            if (Id == -1)
                return null;
            try
            {
                _cachedInfo = _callManager.CallApiProvider.GetInfo(Id);
                return _cachedInfo;
            }
            catch (PjsipErrorException)
            {
                _cachedInfo = _callManager.CallApiProvider.GetInfo(Id);
                return _cachedInfo;
            }
        }

        public void HandleSignallingStateChanged()
        {
            _signallingSession.HandleStateChanged();
        }

        public void HandleMediaStateChanged()
        {
            _mediaSession.HandleStateChanged();
        }

        private void OnStateChanged()
        {
            _callManager.RaiseCallStateChanged(this);
        }

        public bool Equals(IIdentifiable<ICall> other)
        {
            return EqualsTemplate.Equals(this, other);
        }

        public bool DataEquals(ICall other)
        {
            return true;
        }

        public override string ToString()
        {
            return ToString(false);
        }

        public virtual string ToString(bool withMedia)
        {
            if (Id == -1)
                return base.ToString();

            return _callManager.CallApiProvider.Dump(Id, withMedia, (uint) (withMedia ? 2000 : 1000), " ");
        }

        #endregion

        #region Implementation of IDisposable

        protected override void CleanUp()
        {
            _logger.Debug("Call " + Id + " disposed");
            if (_accountLock != null)
            {
                _accountLock.Dispose();
                _account = null;
            }
            _accountLock = null;
        }

        #endregion

        # region IMediaSource

        public void RecordTo(string fileName)
        {
            _mediaSession.RecordTo(fileName);
        }

        # endregion
    }
}