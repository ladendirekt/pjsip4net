using Moq;
using NUnit.Framework;
using pjsip4net.Configuration;
using pjsip4net.Core;
using pjsip4net.Interfaces;
using pjsip4net.Transport;

namespace pjsip4net.Tests
{
// ReSharper disable InconsistentNaming
    [TestFixture]
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
    }
    // ReSharper restore InconsistentNaming
}