using System;
using System.Diagnostics;
using System.Linq;
using Common.Logging;
using pjsip4net.Accounts;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;
using pjsip4net.Core.Data.Events;
using pjsip4net.Transport;

namespace pjsip4net
{
    internal class DefaultSipUserAgent : Resource, ISipUserAgentInternal
    {
        private readonly IBasicApiProvider _basicApi;
        private readonly LoggingConfig _loggingConfig;
        private readonly IContainer _container;

        public DefaultSipUserAgent(IBasicApiProvider basicApi, IEventsProvider eventsProvider, LoggingConfig loggingConfig, 
            IContainer container)
        {
            Helper.GuardNotNull(basicApi);
            Helper.GuardNotNull(eventsProvider);
            Helper.GuardNotNull(loggingConfig);
            Helper.GuardNotNull(container);
            _basicApi = basicApi;
            _loggingConfig = loggingConfig;
            _container = container;
            _loggingConfig = loggingConfig;

            eventsProvider.Subscribe<LogRequested>(OnLog);
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

        public ISipUserAgent Start()
        {
            var localRegistry = Container.Get<IRegistry>();
            if (localRegistry.Config == null)
                throw new InvalidOperationException("You should call Build first to build up user agent infrastructure.");

            var transportFactory = Container.Get<IVoIPTransportFactory>();
            localRegistry.SipTransport =
                transportFactory.CreateTransport(localRegistry.TransportConfig.Part1,
                                                 localRegistry.TransportConfig.Part2)
                    .As<VoIPTransport>();
            var tptApiProvider = Container.Get<ITransportApiProvider>();
            localRegistry.SipTransport.SetId(
                tptApiProvider.CreateTransportAndGetId(localRegistry.SipTransport.TransportType,
                                                       localRegistry.SipTransport.Config));

            localRegistry.RtpTransport =
                transportFactory
                .CreateTransport(TransportType.Udp,
                                 new TransportConfig()
                                 {
                                    BoundAddress = localRegistry.SipTransport.Config.BoundAddress,
                                    PublicAddress = localRegistry.SipTransport.Config.PublicAddress
                                 })
                .As<VoIPTransport>();

            using (localRegistry.RtpTransport.InitializationScope())
                localRegistry.RtpTransport.Config.Port = 4000;

            Container.RegisterAsSingleton(localRegistry.SipTransport);

            var mediaApiProvider = Container.Get<IMediaApiProvider>();
            mediaApiProvider.CreateMediaTransport(localRegistry.RtpTransport.Config);

            var basicApiProvider = Container.Get<IBasicApiProvider>();
            basicApiProvider.Start();

            var mediaMgr = Container.Get<IMediaManagerInternal>();
            Helper.GuardNotNull(mediaMgr);
            mediaMgr.SetDevices();

            var objectFactory = Container.Get<IObjectFactory>();
            var accMgr = Container.Get<IAccountManagerInternal>();
            //always register local account first
            var account = objectFactory.Create<Account>();
            using (account.InitializationScope())
            {
                account.IsLocal = true;
                account.Transport = localRegistry.SipTransport;
            }
            accMgr.RegisterAccount(account, true);
            //TODO: generalize transport injection

            //register configured accounts
            var accountConfigs = localRegistry.AccountConfigs as AccountConfig[] ?? localRegistry.AccountConfigs.ToArray();
            if (accountConfigs.Any())
                foreach (var accCfg in accountConfigs)
                {
                    var acc = objectFactory.Create<Account>();
                    using (acc.InitializationScope())
                    {
                        acc.SetConfig(accCfg);
                        acc.Transport = localRegistry.SipTransport;
                    }
                    accMgr.RegisterAccount(acc, acc.Config.IsDefault);
                }

            return this;
        }

        public void DumpInfo(bool detail)
        {
            _basicApi.Dump(detail);
        }

        public void Destroy()
        {
            InternalDispose();
        }

        public IContainer Container { get { return _container; } }

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

        //for backwards compatibility sake
        private void OnLog(LogRequested e)
        {
            var message = e.Message;
            if (_loggingConfig.TraceAndDebug)
                Trace.Write(message);
            if (e.Level <= 2)
                Helper.LastError = message;

            Log(this, new LogEventArgs(e.Level, e.Message));
        }

        protected override void CleanUp()
        {
            base.CleanUp();
            _basicApi.Destroy();
        }
    }
}