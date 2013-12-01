using pjsip4net.Core;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;
using pjsip4net.Transport;

namespace pjsip4net.Configuration
{
    public class DefaultTransportComponentConfigurator : IConfigureComponents
    {
        public void Configure(IContainer container)
        {
            Helper.GuardNotNull(container);
            container.RegisterAsSingleton<IVoIPTransportFactory, DefaultVoIPTransportFactory>();
        }
    }
}