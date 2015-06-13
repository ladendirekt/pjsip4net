using System;
using System.Collections.Generic;
using System.Linq;
using pjsip4net.Core.Container;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using Common.Logging;

namespace pjsip4net.Core.Configuration
{
    /// <summary>
    /// An entry point into fluent configuration API
    /// </summary>
    public class Configure
    {
        private Func<ITransportApiProvider, Core.Utils.Tuple<TransportType, TransportConfig>> _defaultTptConfig =
            p => new Core.Utils.Tuple<TransportType, TransportConfig>(TransportType.Udp, null);
        private Func<ITransportApiProvider, Core.Utils.Tuple<TransportType, TransportConfig>> _tptConfigurator;
        private Func<IAccountApiProvider, IEnumerable<AccountConfig>> _accConfigurator;

        private List<Action<IConfigurationContext>> _codeConfigurators =
            new List<Action<IConfigurationContext>>();
        
        private List<IConfigurationProvider> _configProviders = 
            new List<IConfigurationProvider>();

        private readonly List<IConfigureComponents> _configurators = new List<IConfigureComponents>();

        internal List<IConfigureComponents> Configurators
        {
            get { return _configurators; }
        }

        public IContainer Container { get; set; }

        public Configure()
        {
            Container = new SimpleContainer();
            var logger = LogManager.GetLogger<object>();
            Container.RegisterAsSingleton(logger);
        }

        /// <summary>
        /// This method should be used to start configuration.
        /// </summary>
        /// <returns></returns>
        public static Configure Pjsip4Net()
        {
            return new Configure();
        }

        /// <summary>
        /// Lets you configure with block of code.
        /// </summary>
        /// <param name="codeConfigurator">Code block that modifies configuration data.</param>
        /// <returns></returns>
        public Configure With(Action<IConfigurationContext> codeConfigurator)
        {
            Helper.GuardNotNull(codeConfigurator);
            _codeConfigurators.Add(codeConfigurator);
            return this;
        }

        /// <summary>
        /// Lets you provide alternative sources of configuration.
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
        /// Lets you inject your services into dependency injection <see cref="IContainer"/>
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
        /// Lets you configure sip transport explicitly.
        /// </summary>
        /// <param name="tptConfigurator"></param>
        /// <returns></returns>
        public Configure WithSipTransport(Func<ITransportApiProvider, Core.Utils.Tuple<TransportType, TransportConfig>> tptConfigurator)
        {
            Helper.GuardNotNull(tptConfigurator);
            _tptConfigurator = tptConfigurator;
            return this;
        }
        
        /// <summary>
        /// Lets you configure accounts explicitly.
        /// </summary>
        /// <param name="accConfigurator"></param>
        /// <returns></returns>
        public Configure WithAccounts(Func<IAccountApiProvider, IEnumerable<AccountConfig>> accConfigurator)
        {
            Helper.GuardNotNull(accConfigurator);
            _accConfigurator = accConfigurator;
            return this;
        }

        internal bool RequireDynamicDiscovery()
        {
            return !_configurators.OfType<IConfigureApi>().Any();
        }

        internal void RunConfigurators()
        {
            _configurators.Each(c => c.Configure(Container));
        }

        internal Configure RunConfigurationProviders()
        {
            var ctx = Container.Get<IConfigurationContext>();
            _codeConfigurators.Each(a => a(ctx));
            _configProviders.Each(p => p.Configure(ctx));
            return this;
        }

        internal Core.Utils.Tuple<TransportType, TransportConfig> GetConfiguredTransport(ITransportApiProvider transportApiProvider)
        {
            return _tptConfigurator != null ? _tptConfigurator(transportApiProvider) : null;
        }

        public Core.Utils.Tuple<TransportType, TransportConfig> GetDefaultTransport(ITransportApiProvider transportApiProvider)
        {
            return _defaultTptConfig(transportApiProvider);
        }

        internal IEnumerable<AccountConfig> GetConfiguredAccounts(IAccountApiProvider accountApiProvider)
        {
            return _accConfigurator != null ? _accConfigurator(accountApiProvider) : Enumerable.Empty<AccountConfig>();
        }
    }
}