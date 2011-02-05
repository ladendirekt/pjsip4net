using System;
using System.Collections.Generic;
using System.Linq;
using pjsip4net.Core.Container;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;

namespace pjsip4net.Core.Configuration
{
    public class Configure
    {
        private Func<ITransportApiProvider, Tuple<TransportType,TransportConfig>> _defaultTptConfig =
            p => new Tuple<TransportType, TransportConfig>(TransportType.Udp, null);
        private Func<ITransportApiProvider, Tuple<TransportType, TransportConfig>> _tptConfigurator;
        private Func<IAccountApiProvider, IEnumerable<AccountConfig>> _accConfigurator;

        private List<Action<UaConfig, LoggingConfig, MediaConfig>> _codeConfigurators =
            new List<Action<UaConfig, LoggingConfig, MediaConfig>>();
        
        private List<IConfigurationProvider> _configProviders = 
            new List<IConfigurationProvider>();

        private List<IConfigureComponents> _configurators = new List<IConfigureComponents>();

        internal IContainer Container { get; set; }

        public Configure()//todo: investigate whether it is possible to give an autofixture an instance of public class with internal ctor
        {
            Container = new SimpleContainer();
        }

        public static Configure Pjsip4Net()
        {
            return new Configure();
        }

        public Configure With(Action<UaConfig, LoggingConfig, MediaConfig> codeConfigurator)
        {
            Helper.GuardNotNull(codeConfigurator);
            _codeConfigurators.Add(codeConfigurator);
            return this;
        }

        public Configure With(IConfigurationProvider provider)
        {
            Helper.GuardNotNull(provider);
            _configProviders.Add(provider);
            return this;
        }

        public Configure With(IConfigureComponents componentsConfigurator)
        {
            return AddComponentConfigurator(componentsConfigurator);
        }

        public Configure WithSipTransport(Func<ITransportApiProvider, Tuple<TransportType, TransportConfig>> tptConfigurator)
        {
            Helper.GuardNotNull(tptConfigurator);
            _tptConfigurator = tptConfigurator;
            return this;
        }
        
        public Configure WithAccounts(Func<IAccountApiProvider, IEnumerable<AccountConfig>> accConfigurator)
        {
            Helper.GuardNotNull(accConfigurator);
            _accConfigurator = accConfigurator;
            return this;
        }

        public Configure AddComponentConfigurator(IConfigureComponents configurator)
        {
            Helper.GuardNotNull(configurator);
            _configurators.Add(configurator);
            return this;
        }

        internal void RunConfigurators()
        {
            _configurators.Each(c => c.Configure(Container));
        }

        internal Configure RunConfigurationProviders()
        {
            var ctx = Container.Get<IConfigurationContext>();
            _codeConfigurators.Each(a => a(ctx.Config, ctx.LoggingConfig, ctx.MediaConfig));
            _configProviders.Each(p => p.Configure(ctx));
            return this;
        }

        internal Tuple<TransportType, TransportConfig> GetConfiguredTransport(ITransportApiProvider transportApiProvider)
        {
            return _tptConfigurator != null ? _tptConfigurator(transportApiProvider) : null;
        }

        public Tuple<TransportType, TransportConfig> GetDefaultTransport(ITransportApiProvider transportApiProvider)
        {
            return _defaultTptConfig(transportApiProvider);
        }

        internal IEnumerable<AccountConfig> GetConfiguredAccounts(IAccountApiProvider accountApiProvider)
        {
            return _accConfigurator != null ? _accConfigurator(accountApiProvider) : Enumerable.Empty<AccountConfig>();
        }
    }
}