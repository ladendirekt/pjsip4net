using Moq;
using NUnit.Framework;
using pjsip4net.Configuration;
using pjsip4net.Core;
using pjsip4net.Interfaces;
using pjsip4net.Transport;

namespace pjsip4net.Tests
{
    public class given_a_default_transport_configurator : 
        given_a_component_configurator<DefaultTransportComponentConfigurator>
    {
        [Test]
        public void when_configure_is_called__should_register_default_transportFactory_as_singleton()
        {
            when_configure_called();
            _container.Verify(x => x.RegisterAsSingleton<IVoIPTransportFactory, DefaultVoIPTransportFactory>(),
                              Times.Exactly(1));
        }

        [Test]
        public void when_configure_is_called__should_register_3_transports()
        {
            when_configure_called();
            _container.Verify(
                x =>
                x.Register<IVoIPTransport, UdpTransport>(It.Is<string>(s => TransportType.Udp.ToString().Equals(s))),
                Times.Exactly(1));
            _container.Verify(
                x =>
                x.Register<IVoIPTransport, TcpTransport>(It.Is<string>(s => TransportType.Tcp.ToString().Equals(s))),
                Times.Exactly(1));
            _container.Verify(
                x =>
                x.Register<IVoIPTransport, TlsTransport>(It.Is<string>(s => TransportType.Tls.ToString().Equals(s))),
                Times.Exactly(1));
        }
    }
}