using System;
using System.Diagnostics;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;
using pjsip4net.Core.Data.Events;

namespace pjsip4net
{
    internal class DefaultSipUserAgent : Resource, ISipUserAgentInternal
    {
        private readonly IBasicApiProvider _basicApi;
        private readonly IEventsProvider _eventsProvider;
        private readonly LoggingConfig _loggingConfig;

        public DefaultSipUserAgent(IBasicApiProvider basicApi, IEventsProvider eventsProvider, 
            LoggingConfig loggingConfig)
        {
            Helper.GuardNotNull(basicApi);
            Helper.GuardNotNull(eventsProvider);
            Helper.GuardNotNull(loggingConfig);
            _basicApi = basicApi;
            _loggingConfig = loggingConfig;
            _eventsProvider = eventsProvider;
            _loggingConfig = loggingConfig;

            _eventsProvider.Subscribe<LogRequested>(OnLog);
        }

        #region Implementation of IDisposable

        public void Dispose()
        {
            InternalDispose();
        }

        #endregion

        #region Implementation of ISipUserAgent

        public IImManager ImManager { get; private set; }
        public ICallManager CallManager { get; private set; }
        public IAccountManager AccountManager { get; private set; }
        public IMediaManager MediaManager { get; private set; }

        public event EventHandler<LogEventArgs> Log = delegate { };

        public void DumpInfo(bool detail)
        {
            _basicApi.Dump(detail);
        }

        public void Destroy()
        {
            InternalDispose();
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
            if (_loggingConfig.TraceAndDebug)
                Trace.Write(e.Message);
            if (e.Level <= 2)
                Helper.LastError = e.Message;

            Log(this, new LogEventArgs(e.Level, e.Message));
        }

        protected override void CleanUp()
        {
            base.CleanUp();
            _basicApi.Destroy();
        }
    }
}