using System;
using System.Diagnostics;
using pjsip4net.Core;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;
using pjsip4net.Core.Data.Events;

namespace pjsip4net
{
    internal class DefaultSipUserAgent : Resource, ISipUserAgentInternal
    {
        private IBasicApiProvider _basicApi;
        private readonly IEventsProvider _eventsProvider;
        private ILocalRegistry _localRegistry;
        private readonly IContainer _container;

        public DefaultSipUserAgent(IBasicApiProvider basicApi, IEventsProvider eventsProvider, 
            ILocalRegistry localRegistry, IContainer container)
        {
            Helper.GuardNotNull(basicApi);
            Helper.GuardNotNull(eventsProvider);
            Helper.GuardNotNull(localRegistry);
            Helper.GuardNotNull(container);
            _basicApi = basicApi;
            _localRegistry = localRegistry;
            _container = container;
            _eventsProvider = eventsProvider;

            _eventsProvider.Subscribe<LogRequested>(e => OnLog(e));
        }

        #region Implementation of IDisposable

        public void Dispose()
        {
            ((IResource)this).InternalDispose();
        }

        #endregion

        #region Implementation of ISipUserAgent

        public IImManager ImManager { get; private set; }
        public ICallManager CallManager { get; private set; }
        public IAccountManager AccountManager { get; private set; }
        public IMediaManager MediaManager { get; private set; }
        public IContainer Container
        {
            get { return _container; }
        }

        public event EventHandler<LogEventArgs> Log = delegate { };

        public void DumpInfo(bool detail)
        {
            _basicApi.Dump(detail);
        }

        public void Destroy()
        {
            ((IResource)this).InternalDispose();
        }

        public void SetManagers(IImManager imManager, ICallManager callManager, 
            IAccountManager accountManager, IMediaManager mediaManager)
        {
            Helper.GuardNotNull(imManager);
            Helper.GuardNotNull(callManager);
            Helper.GuardNotNull(accountManager);
            Helper.GuardNotNull(mediaManager);
            ImManager = imManager;
            CallManager = callManager;
            AccountManager = accountManager;
            MediaManager = mediaManager;
        }

        #endregion

        private void OnLog(LogRequested e)
        {
            if (_localRegistry.LoggingConfig.TraceAndDebug)
                Trace.Write(e.Message);
            if (e.Level <= 2)
                Helper.LastError = e.Message;

            Log(this, new LogEventArgs(e.Level, e.Message));
        }

        protected override void CleanUp()
        {
            base.CleanUp();
            
            CallManager.HangupAll();
            var mgr = AccountManager.As<IAccountManagerInternal>();
            if (mgr != null)
                mgr.UnRegisterAllAccounts();

            _localRegistry.SipTransport.InternalDispose();
            _localRegistry.RtpTransport.InternalDispose();

            ImManager = null;
            CallManager = null;
            AccountManager = null;
            MediaManager = null;

            _basicApi.Destroy();
        }
    }
}