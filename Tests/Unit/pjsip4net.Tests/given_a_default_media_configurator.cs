using Moq;
using NUnit.Framework;
using pjsip4net.Configuration;
using pjsip4net.Core.Data;
using pjsip4net.Interfaces;
using pjsip4net.Media;

namespace pjsip4net.Tests
{
    [TestFixture]
    public class given_a_default_media_configurator : given_a_component_configurator<DefaultMediaComponentConfigurator>
    {
        [Test]
        public void when_configure_is_called__should_register_default_conference_bridge_as_singleton()
        {
            when_configure_called();
            _container.Verify(x => x.RegisterAsSingleton<IConferenceBridge, DefaultConferenceBridge>());
        }
        
        [Test]
        public void when_configure_is_called__should_register_default_media_manager_with_internal_interface_as_singleton()
        {
            when_configure_called();
            _container.Verify(x => x.RegisterAsSingleton<IMediaManager, DefaultMediaManager>());
            _container.Verify(x => x.RegisterAsSingleton(It.IsAny<IMediaManagerInternal>()));
        }
        
        [Test]
        public void when_configure_is_called__should_register_wavPlayer_as_transient()
        {
            when_configure_called();
            _container.Verify(x => x.Register<IWavPlayer, WavPlayer>());
        }

        [Test]
        public void when_configure_is_called__should_register_codecInfo_as_transient()
        {
            when_configure_called();
            _container.Verify(x => x.Register<CodecInfo, CodecInfo>());
        }
    }
}