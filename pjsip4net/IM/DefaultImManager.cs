using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Common.Logging;
using pjsip4net.Core;
using pjsip4net.Core.Data.Events;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.IM
{
    internal class DefaultImManager : Initializable, IImManagerInternal
    {
        #region Private Data

        private readonly IIMApiProvider _imApi;
        private readonly ICallApiProvider _callApi;
        private readonly IEventsProvider _eventsProvider;
        private readonly IRegistry _localRegistry;

        private readonly SortedDictionary<int, Buddy> _buddies = new SortedDictionary<int, Buddy>();
        private readonly object _instLock = new object();
        private Buddy _pendingBuddy;
        private readonly ILog _logger = LogManager.GetLogger<IImManager>();

        #endregion

        public DefaultImManager(IRegistry localRegistry, IIMApiProvider imApi, 
            ICallApiProvider callApi, IEventsProvider eventsProvider)
        {
            Helper.GuardNotNull(localRegistry);
            Helper.GuardNotNull(imApi);
            Helper.GuardNotNull(callApi);
            Helper.GuardNotNull(eventsProvider);
            _imApi = imApi;
            _callApi = callApi;
            _eventsProvider = eventsProvider;
            _localRegistry = localRegistry; 
        }

        #region Properties

        public ReadOnlyCollection<IBuddy> Buddies
        {
            get
            {
                lock (_instLock)
                {
                    return _buddies.Values.Cast<IBuddy>().ToList().AsReadOnly();
                }
            }
        }

        public event EventHandler<BuddyStateChangedEventArgs> BuddyStateChanged = delegate { };
        public event EventHandler<PagerEventArgs> IncomingMessage = delegate { };
        public event EventHandler<TypingEventArgs> TypingAlert = delegate { };
        public event EventHandler<NatEventArgs> NatDetected = delegate { };

        public IIMApiProvider Provider
        {
            get { return _imApi; }
        }

        #endregion

        #region Methods

        public void Dispose()
        {
            GuardDisposed();
            GuardNotInitialized();
            Dispose(true);
        }

        public override void BeginInit()
        {
            GuardInitialized();
            base.BeginInit();
        }

        public override void EndInit()
        {
            base.EndInit();

            _eventsProvider.Subscribe<NatDetected>(OnNatDetect);
            _eventsProvider.Subscribe<BuddyStateChanged>(OnBuddyState);
            _eventsProvider.Subscribe<IncomingSubscribeRecieved>(OnIncomingSubscribe);
            _eventsProvider.Subscribe<IncomingImRecieved>(OnPager);
            _eventsProvider.Subscribe<ImStatusChanged>(OnPagerStatus);
            _eventsProvider.Subscribe<IncomingTypingRecieved>(OnTyping);
        }

        private void OnNatDetect(NatDetected e)
        {
            NatDetected(this, new NatEventArgs(e));
        }

        private void OnBuddyState(BuddyStateChanged e)
        {
            lock (_instLock)
            {
                if (_buddies.ContainsKey(e.Id) && _buddies[e.Id] != null)
                    RaiseBuddyState(_buddies[e.Id]);
                else if (_pendingBuddy != null) //this is a new buddy it still does not have an Id
                {
                    _pendingBuddy.SetId(e.Id);
                    RaiseBuddyState(_pendingBuddy);
                }
            }
        }

        private void RaiseBuddyState(Buddy buddy)
        {
            BuddyStateChanged(this, buddy.GetEventArgs());
        }

        private void OnPager(IncomingImRecieved e)
        {
            var ea = new PagerEventArgs(e.From, e.To, e.Contact, e.MimeType, e.CallId, e.Body);
            IncomingMessage(this, ea);
        }

        private void OnPagerStatus(ImStatusChanged e)
        {
            _logger.DebugFormat("pager {0}", e.Status);
        }

        private void OnTyping(IncomingTypingRecieved e)
        {
            var ea = new TypingEventArgs(e.From, e.To, e.Contact, e.CallId, e.IsTyping);
            TypingAlert(this, ea);
        }

        private void OnIncomingSubscribe(IncomingSubscribeRecieved e)
        {
            _logger.Debug("Incoming SUBSCRIBE");
        }

        public void RegisterBuddy(Buddy buddy)
        {
            if (buddy != null)
                lock (_instLock)
                {
                    try
                    {
                        _pendingBuddy = buddy;
                        int id = -1;
                        id = _imApi.AddBuddyAndGetId(buddy.Config);
                        buddy.SetId(id);
                        _buddies.Add(buddy.Id, buddy);
                        if (buddy.MonitoringPresence)
                            _imApi.SubscribeBuddyPresence(id);
                    }
                    finally
                    {
                        _pendingBuddy = null;
                    }
                }
        }

        public void UnregisterBuddy(Buddy buddy)
        {
            lock (_instLock)
            {
                if (buddy.Id != -1)
                {
                    _imApi.DeleteBuddy(buddy.Id);
                    _buddies.Remove(buddy.Id);
                    buddy.InternalDispose();
                }
            }
        }

        public IBuddy RegisterBuddy(Func<IBuddyBuilder, IBuddy> builder)
        {
            Helper.GuardNotNull(builder);
            return builder(_localRegistry.Container.Get<IBuddyBuilder>());
        }

        public IBuddy GetBuddyById(int id)
        {
            lock (_instLock)
            {
                if (_buddies.ContainsKey(id))
                    return _buddies[id];
                if (id == -1 && _pendingBuddy != null)
                    return _pendingBuddy;
                return null;
            }
        }

        public void SendMessage(Action<IMessageBuilder> builder)
        {
            Helper.GuardNotNull(builder);
            builder(_localRegistry.Container.Get<IMessageBuilder>());
        }

        public void SendTyping(IAccount account, string to, bool isTyping)
        {
            _imApi.SendIsTyping(account.Id, to);
        }

        public void SendMessage(IAccount account, string body, string to)
        {
            _imApi.SendIm(account.Id, to, "text/plain", body);
        }

        public void SendTypingInDialog(ICall dialog, bool isTyping)
        {
            Helper.GuardNotNull(dialog);
            Helper.GuardPositiveInt(dialog.Id);
            _callApi.SendTypingInd(dialog.Id, isTyping);
        }

        public void DumpSubscription(bool verbose)
        {
            _imApi.DumpPresence(verbose);
        }

        public void SendMessageInDialog(ICall dialog, string body)
        {
            Helper.GuardNotNull(dialog);
            Helper.GuardPositiveInt(dialog.Id);
            _callApi.SendIm(dialog.Id, "text/plain", body);
        }

        #endregion
    }
}