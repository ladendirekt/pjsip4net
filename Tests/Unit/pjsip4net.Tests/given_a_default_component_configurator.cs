using System;
using Moq;
using NUnit.Framework;
using pjsip4net.Configuration;
using pjsip4net.Core.Interfaces;
using pjsip4net.IM;
using pjsip4net.IM.Dsl;
using pjsip4net.Interfaces;

namespace pjsip4net.Tests
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_a_default_component_configurator : given_a_component_configurator<DefaultComponentConfigurator>
    {
        [Test]
        public void when_configure_is_called__should_register_default_objectFactory()
        {
            when_configure_called();
            _container.Verify(x => x.RegisterAsSingleton<IObjectFactory, DefaultObjectFactory>(), Times.Exactly(1));
        }
        
        [Test]
        public void when_configure_is_called__should_register_default_localRegistry_with_configCtx()
        {
            when_configure_called();
            _container.Verify(x => x.RegisterAsSingleton<ILocalRegistry, DefaultLocalRegistry>(), Times.Exactly(1));
            _container.Verify(x => x.RegisterAsSingleton(It.IsAny<IConfigurationContext>()), Times.Exactly(1));
        }

        [Test]
        public void when_configure_is_called__should_register_default_im_manager_as_singleton()
        {
            when_configure_called();
            _container.Verify(x => x.RegisterAsSingleton<IImManager, DefaultImManager>());
        }

        [Test]
        public void when_configure_is_called__should_register_default_message_builder_as_transient()
        {
            when_configure_called();
            _container.Verify(x => x.Register<IMessageBuilder, DefaultMessageBuilder>());
        }
    }
    // ReSharper restore InconsistentNaming
}