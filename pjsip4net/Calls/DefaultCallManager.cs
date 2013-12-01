using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Common.Logging;
using pjsip4net.Accounts;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Data.Events;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls
{
    internal class DefaultCallManager : Initializable, ICallManagerInternal
    {
        #region Private data

        private readonly ILog _logger = LogManager.GetLogger<ICallManager>();
        private static readonly object _lock = new object();

        private readonly SortedDictionary<int, Call> _activeCalls = new SortedDictionary<int, Call>();
        private readonly ManualResetEvent _barrier;
        private MruCache<ValueWrapper<int>, CallStateChangedEventArgs> _eaCache;
        private readonly IObjectFactory _objectFactory;
        private readonly IBasicApiProvider _basicApi;
        private readonly ICallApiProvider _callApi;
        private readonly IMediaApiProvider _mediaApi;
        private readonly IEventsProvider _eventsProvider;
        private readonly IRegistry _localRegistry;
        private readonly IAccountManagerInternal _accMgr;

        #endregion

        public DefaultCallManager(IObjectFactory objectFactory, ICallApiProvider callApi, IRegistry localRegistry, 
            IBasicApiProvider basicApi, IMediaApiProvider mediaApi, IEventsProvider eventsProvider, IAccountManagerInternal accMgr)
        {
            Helper.GuardNotNull(objectFactory);
            Helper.GuardNotNull(basicApi);
            Helper.GuardNotNull(callApi);
            Helper.GuardNotNull(mediaApi);
            Helper.GuardNotNull(localRegistry);
            Helper.GuardNotNull(eventsProvider);
            _objectFactory = objectFactory;
            _accMgr = accMgr;
            _mediaApi = mediaApi;
            _eventsProvider = eventsProvider;
            _basicApi = basicApi;
            _localRegistry = localRegistry;
            _callApi = callApi;

            _barrier = new ManualResetEvent(true);
        }

        #region Properties

        private uint _maxCalls;
        public event EventHandler<EventArgs<ICall>> IncomingCall = delegate { };
        public event EventHandler<CallStateChangedEventArgs> CallStateChanged = delegate { };
        public event EventHandler<DtmfEventArgs> IncomingDtmfDigit = delegate { };
        public event EventHandler<RingEventArgs> Ring = delegate { };
        public event EventHandler<CallTransferEventArgs> CallTransfer = delegate { };
        public event EventHandler<CallRedirectedEventArgs> CallRedirected = delegate { };

        public ReadOnlyCollection<ICall> Calls
        {
            get
            {
                lock (_lock)
                    return new ReadOnlyCollection<ICall>(new List<ICall>(_activeCalls.Values.Cast<ICall>()));
            }
        }

        public uint MaxCalls
        {
            get { return _maxCalls; }
            set
            {
                _maxCalls = value;
                _eaCache = new MruCache<ValueWrapper<int>, CallStateChangedEventArgs>((int) _maxCalls);
            }
        }

        public IBasicApiProvider BasicApiProvider
        {
            get { return _basicApi; }
        }

        public ICallApiProvider CallApiProvider
        {
            get { return _callApi; }
        }

        public IMediaApiProvider MediaApiProvider
        {
            get { return _mediaApi; }
        }

        #endregion

        #region Methods

        public ICall MakeCall(string destinationUri)
        {
            return MakeCall(_accMgr.DefaultAccount, destinationUri);
        }

        public ICall MakeCall(IAccount account, string destinationUri)
        {
            Helper.GuardNotNull(account);
            return MakeCall(x =>
            {
                var sipUriParser = new SipUriParser(destinationUri);
                return x.From(account).To(sipUriParser.Extension).At(sipUriParser.Domain).Through(sipUriParser.Port).Call();
            });
        }

        public ICall MakeCall(Func<ICallBuilder, ICall> builder)
        {
            Helper.GuardNotNull(builder);
            Helper.GuardInRange(0u, MaxCalls - 1, (uint)_activeCalls.Count);
            return builder(_localRegistry.Container.Get<ICallBuilder>());
        }

        public void HangupAll()
        {
            foreach (Call call in Calls)
                try
                {
                    call.Hangup();
                }
                catch (ObjectDisposedException)
                {
                }
            //_barrier.WaitOne(TimeSpan.FromSeconds(1));
        }

        public ICall GetCallById(int id)
        {
            lock (_lock)
                if (_activeCalls.ContainsKey(id))
                    return _activeCalls[id];
            return null;
        }

        public void TerminateCall(Call call)
        {
            Helper.GuardNotNull(call);
            lock (_lock)
            {
                if (_activeCalls.ContainsKey(call.Id))
                    _activeCalls.Remove(call.Id);
                else
                    throw new InvalidOperationException("There is no call with id = " + call.Id +
                                                        " in active calls. Can not terminate.");

                call.InternalDispose();
                if (_activeCalls.Count == 0)
                    _barrier.Set();
            }
        }

        public override void EndInit()
        {
            base.EndInit();
            _eventsProvider.Subscribe<CallStateChanged>(OnCallState);
            _eventsProvider.Subscribe<CallMediaStateChanged>(OnCallMediaState);
            _eventsProvider.Subscribe<IncomingCallRecieved>(OnIncomingCall);
            _eventsProvider.Subscribe<StreamDestroyed>(OnStreamDestroyed);
            _eventsProvider.Subscribe<DtmfRecieved>(OnDtmfDigit);
            _eventsProvider.Subscribe<CallTransferRequested>(OnCallTransfer);
            _eventsProvider.Subscribe<CallTransferStatusChanged>(OnCallTransferStatus);
            _eventsProvider.Subscribe<CallRedirected>(OnCallRedirected);
        }

        public void RegisterCall(Call call)
        {
            lock (_lock)
            {
                Helper.GuardNotNull(call);

                call.SetId(_callApi.MakeCallAndGetId(call.Account.Id, call.DestinationUri, 0));
                AddCallAndUpdateEaCache(call.DestinationUri, call);

                call.HandleInviteStateChanged();

                _barrier.Reset();
            }
        }

        public void RaiseCallStateChanged(Call call)
        {
            CallStateChangedEventArgs ea;
            if (_eaCache.TryGetValue(new ValueWrapper<int>(call.Id), out ea))
            {
                ea.InviteState = call.InviteState;
                ea.MediaState = call.MediaState;
                CallStateChanged(this, ea);
            }
        }

        public void RaiseRingEvent(Call call, bool ringOn)
        {
            call.InviteSession.IsRinging = true;
            Ring(this, new RingEventArgs(ringOn, call));
        }

        public void OnCallState(CallStateChanged e)
        {
            lock (_lock)
                if (_activeCalls.ContainsKey(e.Id) && _activeCalls[e.Id] != null)
                {
                    CallStateChangedEventArgs ea;
                    if (_eaCache.TryGetValue(new ValueWrapper<int>(e.Id), out ea))
                    {
                        ea.DestinationUri = _activeCalls[e.Id].DestinationUri;
                        ea.Duration = _activeCalls[e.Id].TotalDuration;
                    }
                    _activeCalls[e.Id].HandleInviteStateChanged();
                }
        }

        public void OnIncomingCall(IncomingCallRecieved e)
        {
            Account account = _accMgr.GetAccount(e.AccountId);
            if (account == null) // || !account.IsRegistered)
                account = _accMgr.GetAccount(_accMgr.DefaultAccount.Id);

            _logger.DebugFormat("incoming call for account {0}", account.AccountId);

            if (account != null)
            {
                Monitor.Enter(_lock);
                if (_activeCalls.Count < MaxCalls)
                {
                    var call = _objectFactory.Create<Call>();
                    using (call.InitializationScope())
                    {
                        call.SetId(e.CallId);
                        call.SetAccount(account);
                        call.SetAsIncoming();
                    }
                    AddCallAndUpdateEaCache(account.AccountId, call);
                    Monitor.Exit(_lock);
                    if (_localRegistry.Config.AutoAnswer)
                    {
                        call.Answer(true);
                        if (_activeCalls.Count > 0)
                            _barrier.Reset();
                        return;
                    }

                    RaiseRingEvent(call, true);
                    var ea = new EventArgs<ICall>(call);
                    IncomingCall(this, ea);

                    if (_activeCalls.Count > 0)
                        _barrier.Reset();
                }
                else
                {
                    Monitor.Exit(_lock);
                    _callApi.AnswerCall(e.CallId, SipStatusCode.Decline, "Too much calls");
                }
            }
        }

        public void OnCallMediaState(CallMediaStateChanged e)
        {
            lock (_lock)
                if (_activeCalls.ContainsKey(e.Id) && _activeCalls[e.Id] != null)
                {
                    CallStateChangedEventArgs ea;
                    if (_eaCache.TryGetValue(new ValueWrapper<int>(e.Id), out ea))
                    {
                        ea.DestinationUri = _activeCalls[e.Id].DestinationUri;
                        ea.Duration = _activeCalls[e.Id].TotalDuration;
                    }
                    _activeCalls[e.Id].HandleMediaStateChanged();
                }
        }

        public void OnStreamDestroyed(StreamDestroyed e)
        {
            lock (_lock)
                if (_activeCalls.ContainsKey(e.Id) && _activeCalls[e.Id] != null)
                    _activeCalls[e.Id].HandleMediaStateChanged();
        }

        public void OnDtmfDigit(DtmfRecieved e)
        {
            lock (_lock)
                if (_activeCalls.ContainsKey(e.Id) && _activeCalls[e.Id] != null)
                {
                    var ea = new DtmfEventArgs(_activeCalls[e.Id], e.Digit);
                    IncomingDtmfDigit(this, ea);
                }
        }

        public void OnCallTransfer(CallTransferRequested e)
        {
            lock (_lock)
            {
                var ea = new CallTransferEventArgs
                             {Destination = e.Destination, StatusCode = e.Status, Call = _activeCalls[e.Id]};
                CallTransfer(this, ea);
                e.Status = ea.StatusCode;
            }
        }

        public void OnCallTransferStatus(CallTransferStatusChanged e)
        {
            e.Continue = true;
        }

        public void OnCallRedirected(CallRedirected args)
        {
            var ea = new CallRedirectedEventArgs()
                         {
                             CallId = args.Id,
                             Target = args.Target,
                             Option = args.Option
                         };
            CallRedirected(this, ea);
            args.Option = ea.Option;
        }

        private void AddCallAndUpdateEaCache(string destinationUri, Call call)
        {
            _activeCalls.Add(call.Id, call);
            CallStateChangedEventArgs ea;
            if (!_eaCache.TryGetValue(new ValueWrapper<int>(call.Id), out ea))
            {
                ea = new CallStateChangedEventArgs {Id = call.Id};
                _eaCache.Add(new ValueWrapper<int>(call.Id), ea);
            }
            ea.DestinationUri = destinationUri;
        }

        #endregion
    }
}