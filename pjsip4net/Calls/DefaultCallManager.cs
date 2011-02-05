using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
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
        //#region Singleton

        private static readonly object _lock = new object();
        //private static CallManager _instance;

        public DefaultCallManager(IObjectFactory objectFactory, ICallApiProvider callApi, ILocalRegistry localRegistry, 
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
            //_syncContext = SynchronizationContext.Current;
        }

        #region Private data

        //private SynchronizationContext _syncContext;
        private readonly SortedDictionary<int, ICallInternal> _activeCalls = new SortedDictionary<int, ICallInternal>();
        private readonly ManualResetEvent _barrier;
        private MruCache<ValueWrapper<int>, CallStateChangedEventArgs> _eaCache;
        //private CallStateChangedEventArgs _ea = new CallStateChangedEventArgs();
        private readonly IObjectFactory _objectFactory;
        private readonly IBasicApiProvider _basicApi;
        private readonly ICallApiProvider _callApi;
        private readonly IMediaApiProvider _mediaApi;
        private readonly IEventsProvider _eventsProvider;
        private readonly ILocalRegistry _localRegistry;
        private readonly IAccountManagerInternal _accMgr;

        #endregion

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
            lock (_lock)
            {
                Helper.GuardNotNull(account);
                Helper.GuardInRange(0u, MaxCalls - 1, (uint) _activeCalls.Count);

                var result = _objectFactory.Create<ICallInternal>();
                var acc = _accMgr.GetAccount(account.Id);
                Helper.GuardNotNull(acc);
                result.SetAccount(acc);
                using (result.InitializationScope())
                    result.SetDestinationUri(destinationUri);

                result.SetId(_callApi.MakeCallAndGetId(result.Account.Id, destinationUri, 0));
                AddCallAndUpdateEaCache(destinationUri, result);

                result.HandleInviteStateChanged();

                _barrier.Reset();
                return result;
            }
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

            if (Calls.Count > 0)
                if (!_barrier.WaitOne(TimeSpan.FromSeconds(10.0)))
                    //throw new InvalidOperationException("Time out to wait for all calls to be deleted");
                    return; //close silently
        }

        public ICall GetCallById(int id)
        {
            lock (_lock)
                if (_activeCalls.ContainsKey(id))
                    return _activeCalls[id];
            return null;
        }

        public void TerminateCall(ICallInternal call)
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
            _eventsProvider.Subscribe<CallStateChanged>(e => OnCallState(e));
            _eventsProvider.Subscribe<CallMediaStateChanged>(e => OnCallMediaState(e));
            _eventsProvider.Subscribe<IncomingCallRecieved>(e => OnIncomingCall(e));
            _eventsProvider.Subscribe<StreamDestroyed>(e => OnStreamDestroyed(e));
            _eventsProvider.Subscribe<DtmfRecieved>(e => OnDtmfDigit(e));
            _eventsProvider.Subscribe<CallTransferRequested>(e => OnCallTransfer(e));
            _eventsProvider.Subscribe<CallTransferStatusChanged>(e => OnCallTransferStatus(e));
            _eventsProvider.Subscribe<CallRedirected>(e => OnCallRedirected(e));
        }

        

        public void RaiseCallStateChanged(ICallInternal call)
        {
            CallStateChangedEventArgs ea;
            if (_eaCache.TryGetValue(new ValueWrapper<int>(call.Id), out ea))
            {
                ea.InviteState = call.InviteState;
                ea.MediaState = call.MediaState;
                //try
                //{
                //    if (_syncContext != null)
                //        _syncContext.Post(s => CallStateChanged(this, ea), null);
                //    else
                //        CallStateChanged(this, ea);
                //}
                //catch (InvalidOperationException)
                //{
                CallStateChanged(this, ea);
                //}
            }
        }

        public void RaiseRingEvent(ICallInternal call, bool ringOn)
        {
            //try
            //{
            call.InviteSession.IsRinging = true;
            //    if (_syncContext != null)
            //        _syncContext.Post(s => Ring(this, new RingEventArgs(ringOn, call)), null);
            //    else
            //        Ring(this, new RingEventArgs(ringOn, call));
            //}
            //catch (InvalidOperationException)
            //{
            Ring(this, new RingEventArgs(ringOn, call));
            //}
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
            IAccountInternal account = _accMgr.GetAccount(e.AccountId);
            if (account == null) // || !account.IsRegistered)
                account = _accMgr.GetAccount(_accMgr.DefaultAccount.Id);

            Debug.WriteLine("incoming call for account " + account.AccountId);

            if (account != null)
            {
                Monitor.Enter(_lock);
                if (_activeCalls.Count < MaxCalls)
                {
                    var call = _objectFactory.Create<ICallInternal>();
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
                    //try
                    //{
                    //    if (_syncContext != null)
                    //        _syncContext.Post(delegate { IncomingCall(this, ea); }, null);
                    //    else
                    //        IncomingCall(this, ea);
                    //}
                    //catch (InvalidOperationException)
                    //{
                    IncomingCall(this, ea);
                    //}

                    if (_activeCalls.Count > 0)
                        _barrier.Reset();
                }
                else
                {
                    Monitor.Exit(_lock);
                    //Don't have to create an object here - simply closing this session
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

        private void AddCallAndUpdateEaCache(string destinationUri, ICallInternal call)
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

        //internal static CallManager Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            lock(_lock)
        //                if (_instance == null)
        //                    _instance = new CallManager();
        //        return _instance;
        //    }
        //}

        //#endregion
    }
}