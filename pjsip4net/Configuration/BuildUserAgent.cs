using System;
using System.Linq;
using Common.Logging;
using pjsip4net.Core;
using pjsip4net.Core.Configuration;
using pjsip4net.Core.Container;
using pjsip4net.Core.Data.Events;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Configuration
{
    public static class BuildUserAgent
    {
        /// <summary>
        /// Builds and initializes most of voip services.
        /// </summary>
        /// <exception cref="InvalidOperationException"/>
        /// <exception cref="PjsipErrorException"/>
        /// <exception cref="ArgumentNullException"/>
        public static ISipUserAgent Build(this Configure cfg)
        {
            try
            {
                cfg.Container.RegisterAsSingleton(cfg.Container);
            }
            catch (ContainerException)//it might be already configured somewhere up
            {
            }

            if (cfg.RequireDynamicDiscovery())
                cfg.With(new DynamicApiConfigurator());

            cfg.With(new DefaultComponentConfigurator())
                .With(new DefaultTransportComponentConfigurator())
                .With(new DefaultAccountComponentConfigurator())
                .With(new DefaultCallComponentConfigurator())
                .With(new DefaultMediaComponentConfigurator()).RunConfigurators();

            var localRegistry = cfg.Container.Get<IRegistry>();
            localRegistry.Container = cfg.Container;

            var basicApiProvider = cfg.Container.Get<IBasicApiProvider>();
            if (basicApiProvider == null)
                throw new InvalidOperationException("The API version was neither configured explicitly nor discovered dynamically");

            basicApiProvider.CreatePjsua();

            new DefaultAgentConfigurator().Configure(cfg.Container);
            
            cfg.RunConfigurationProviders();

            var accApi = cfg.Container.Get<IAccountApiProvider>();
            var tptApi = cfg.Container.Get<ITransportApiProvider>();
            if (localRegistry.AccountConfigs != null)
                localRegistry.AccountConfigs.Union(cfg.GetConfiguredAccounts(accApi));
            else
                localRegistry.AccountConfigs = cfg.GetConfiguredAccounts(accApi);
            var tptConfig = cfg.GetConfiguredTransport(tptApi);
            if (tptConfig != null)
                localRegistry.TransportConfig = tptConfig;
            if (localRegistry.TransportConfig == null)
                localRegistry.TransportConfig = cfg.GetDefaultTransport(tptApi);

            var imMgr = cfg.Container.Get<IImManager>();
            Helper.GuardNotNull(imMgr);
            using (imMgr.InitializationScope())
            { }

            var callMgr = cfg.Container.Get<ICallManagerInternal>();
            Helper.GuardNotNull(callMgr);
            using (callMgr.InitializationScope())
            {
                callMgr.MaxCalls = localRegistry.Config.MaxCalls;
            }

            var accMgr = cfg.Container.Get<IAccountManagerInternal>();
            Helper.GuardNotNull(accMgr);
            using (accMgr.InitializationScope())
            { }

            var mediaMgr = cfg.Container.Get<IMediaManagerInternal>();
            Helper.GuardNotNull(mediaMgr);
            using (mediaMgr.InitializationScope())
            { }

            var ua = cfg.Container.Get<ISipUserAgentInternal>();
            Helper.GuardNotNull(ua);
            ua.SetManagers(imMgr, callMgr, accMgr, mediaMgr);

            var eventsProvider = cfg.Container.Get<IEventsProvider>();
            var logger = cfg.Container.Get<ILog>();
            eventsProvider.Subscribe<LogRequested>(e =>
            {
                logger.Log(e);
            });

            basicApiProvider.InitPjsua(localRegistry.Config, localRegistry.LoggingConfig, localRegistry.MediaConfig);

            return cfg.Container.Get<ISipUserAgent>();
        }
    }
}