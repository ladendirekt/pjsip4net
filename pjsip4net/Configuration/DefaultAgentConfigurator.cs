using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Interfaces;

namespace pjsip4net.Configuration
{
    public class DefaultAgentConfigurator : IConfigureComponents
    {
        public void Configure(IContainer container)
        {
            var basicApiProvider = container.Get<IBasicApiProvider>();
            var registry = container.Get<IRegistry>();
            registry.Config = basicApiProvider.GetDefaultUaConfig();
            registry.LoggingConfig = basicApiProvider.GetDefaultLoggingConfig();
            registry.MediaConfig = container.Get<IMediaApiProvider>().GetDefaultConfig();

            container.RegisterAsSingleton(registry.LoggingConfig);
            container.RegisterAsSingleton(registry.Config);
            container.RegisterAsSingleton(registry.MediaConfig);

            container.RegisterAsSingleton<ISipUserAgent, ISipUserAgentInternal, DefaultSipUserAgent>();
        }
    }
}