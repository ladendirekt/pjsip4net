using Moq;
using NUnit.Framework;
using pjsip4net.Calls;
using pjsip4net.Calls.Dsl;
using pjsip4net.Configuration;
using pjsip4net.Interfaces;

namespace pjsip4net.Tests
{
    [TestFixture]
    public class given_a_default_call_configurator : given_a_component_configurator<DefaultCallComponentConfigurator>
    {
        [Test]
        public void when_configure_is_called__should_register_default_call_manager_as_singleton_with_internal_interface()
        {
            _container.Setup(x => x.RegisterAsSingleton<ICallManager, DefaultCallManager>());
            //_container.Setup(x => x.RegisterAsSingleton(It.IsAny<ICallManagerInternal>()));
            when_configure_called();
            _container.Verify(x => x.RegisterAsSingleton<ICallManager, DefaultCallManager>());
            //_container.Verify(x => x.RegisterAsSingleton(It.IsAny<ICallManagerInternal>()));
        }

        [Test]
        public void when_configure_is_called__should_register_call_builder_as_transient()
        {
            when_configure_called();
            _container.Verify(x => x.Register<ICallBuilder, DefaultCallBuilder>());
        }
    }
}