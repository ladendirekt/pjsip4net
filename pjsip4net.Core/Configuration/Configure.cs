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
    /// <summary>
    /// An entry point into fluent configuration API
    /// </summary>
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

        public Configure()
        {
            Container = new SimpleContainer();
        }

        /// <summary>
        /// This method should be used to start configuration like this: Configure.Pjsip4Net()...
        /// </summary>
        /// <returns></returns>
        public static Configure Pjsip4Net()
        {
            return new Configure();
        }

        /// <summary>
        /// Adds closures to code configuration pipeline.
        /// </summary>
        /// <param name="codeConfigurator">Code block that modifies configuration data.</param>
        /// <returns></returns>
        public Configure With(Action<UaConfig, LoggingConfig, MediaConfig> codeConfigurator)
        {
            Helper.GuardNotNull(codeConfigurator);
            _codeConfigurators.Add(codeConfigurator);
            return this;
        }

        /// <summary>
        /// Let you inject alternative sources of configuration.
        /// </summary>
        /// <param name="provider">An abstraction of configuration source.</param>
        /// <returns></returns>
        public Configure With(IConfigurationProvider provider)
        {
            Helper.GuardNotNull(provider);
            _configProviders.Add(provider);
            return this;
        }

        /// <summary>
        /// Let you inject your services into dependency injection <see cref="IContainer"/>
        /// </summary>
        /// <param name="componentsConfigurator"></param>
        /// <returns></returns>
        public Configure With(IConfigureComponents componentsConfigurator)
        {
            Helper.GuardNotNull(componentsConfigurator);
            _configurators.Add(componentsConfigurator);
            return this;
        }

        /// <summary>
        /// Let you configure sip transport explicitly.
        /// </summary>
        /// <param name="tptConfigurator"></param>
        /// <returns></returns>
        public Configure WithSipTransport(Func<ITransportApiProvider, Tuple<TransportType, TransportConfig>> tptConfigurator)
        {
            Helper.GuardNotNull(tptConfigurator);
            _tptConfigurator = tptConfigurator;
            return this;
        }
        
        /// <summary>
        /// Let you configure accounts explicitly.
        /// </summary>
        /// <param name="accConfigurator"></param>
        /// <returns></returns>
        public Configure WithAccounts(Func<IAccountApiProvider, IEnumerable<AccountConfig>> accConfigurator)
        {
            Helper.GuardNotNull(accConfigurator);
            _accConfigurator = accConfigurator;
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