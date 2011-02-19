using System;
using System.Diagnostics;
using Common.Logging;
using pjsip4net.Accounts;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls
{
    internal class Call : Initializable, ICallInternal, IIdentifiable<ICall>
    {
        #region Private data

        private readonly object _lock = new object();
        private readonly MediaSession _mediaSession;
        private readonly ICallManagerInternal _callManager;
        private IAccountInternal _account;
        private IDisposable _accountLock;
        private readonly InviteSession _inviteSession;
        private ILog _logger = LogManager.GetLogger<ICall>();

        #endregion

        #region Properties

        private string _destinationUri;

        public IAccount Account
        {
            get
            {
                GuardDisposed();
                return _account;
            }
        }

        public string DestinationUri
        {
            get
            {
                GuardDisposed();
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
            get { return _inviteSession.InviteState; }
        }

        public CallMediaState MediaState
        {
            get { return _mediaSession.MediaState; }
        }

        public bool IsIncoming { get; private set; }

        public virtual bool IsActive
        {
            get
            {
                GuardDisposed();
                return Id != -1 &&
                       _callManager.CallApiProvider.IsCallActive(Id);
            }
        }

        public bool HasMedia
        {
            get
            {
                GuardDisposed();
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
                GuardDisposed();
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
                GuardDisposed();
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
        
        InviteSession ICallInternal.InviteSession
        {
            get { return _inviteSession; }
        }

        #endregion

        #region Methods

        public Call(ICallManagerInternal callManager, ILocalRegistry registry, IConferenceBridge conferenceBridge)
        {
            Id = -1;
            Helper.GuardNotNull(callManager);
            Helper.GuardNotNull(conferenceBridge);
            Helper.GuardNotNull(registry);
            _callManager = callManager;

            _inviteSession = new InviteSession(this, callManager);
            _inviteSession.StateChanged += delegate { OnStateChanged(); };
            _mediaSession = new MediaSession(this, registry, callManager, conferenceBridge);
            _mediaSession.StateChanged += delegate { OnStateChanged(); };

            CallInfo info = GetCallInfo();
            if (info != null) 
                IsIncoming = info.Role == SipRole.RoleUas;
        }

        //public static ICallBuilder New()
        //{
        //    return new /*ToCallBuilderExpression(new*/ CallBuilder();//);
        //}

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

            _accountLock = ((Account)Account).Lock(); //if everything is ok
        }

        public void Hold()
        {
            GuardDisposed();
            if (_inviteSession.IsConfirmed && IsActive)
                _callManager.CallApiProvider.PutCallOnHold(Id);
        }

        public void ReleaseHold()
        {
            GuardDisposed();
            if (_mediaSession.IsHeld) // media state should reflect correct state [unknown for now]
                _callManager.CallApiProvider.ReinviteCall(Id, true);
        }

        public void Hangup()
        {
            Hangup("");
        }

        public void Hangup(string reason)
        {
            GuardDisposed();
            if (!_inviteSession.IsDisconnected)
                _callManager.CallApiProvider.HangupCall(Id, SipStatusCode.Decline, reason);
        }

        public void Answer(bool accept)
        {
            Answer(accept, "");
        }

        public void Answer(bool accept, string reason)
        {
            GuardDisposed();
            if (!IsIncoming)
                throw new InvalidOperationException("Can not answer on outgoing call");

            if (!_inviteSession.IsConfirmed)
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
            Helper.GuardPositiveInt(id);
            Id = id;
        }

        public void SetDestinationUri(string uri)
        {
            Helper.GuardNotNullStr(uri);
            DestinationUri = uri;
        }

        public void SetAccount(IAccountInternal account)
        {
            Helper.GuardNotNull(account);
            _account = account;
            if (IsIncoming)
                _accountLock = _account.Lock();
        }

        public void SetAsIncoming()
        {
            IsIncoming = true;
        }

        public CallInfo GetCallInfo()
        {
            GuardDisposed();
            //lock (_lock)
            {
                if (Id == -1)
                    return null;
                try
                {
                    return _callManager.CallApiProvider.GetInfo(Id);
                }
                catch (PjsipErrorException)
                {
                    return _callManager.CallApiProvider.GetInfo(Id);
                }
            }
        }

        public void HandleInviteStateChanged()
        {
            _inviteSession.HandleStateChanged();
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
            _accountLock.Dispose();
            _account = null;
            _accountLock = null;
            _inviteSession.Dispose();
            _mediaSession.Dispose();
        }

        #endregion
    }
}