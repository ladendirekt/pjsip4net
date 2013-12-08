using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;

namespace pjsip4net.Testing
{
    public class TestConfigurator : IConfigureApi
    {
        public void Configure(IContainer container)
        {
            container.RegisterAsSingleton<IBasicApiProvider, BasicApiTestProvider>()
                .RegisterAsSingleton<IAccountApiProvider, AccountApiTestProvider>()
                .RegisterAsSingleton<ICallApiProvider, CallApiTestProvider>()
                .RegisterAsSingleton<IIMApiProvider, ImApiTestProvider>()
                .RegisterAsSingleton<ITransportApiProvider, TransportApiTestProvider>()
                .RegisterAsSingleton<IMediaApiProvider, MediaApiTestProvider>();
        }
    }
}