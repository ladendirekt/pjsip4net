using Castle.Windsor;
using pjsip4net.Core.Configuration;

namespace pjsip4net.Container.Castle
{
    public static class ConfigureCastleContainer
    {
        public static Configure CastleContainer(this Configure config)
        {
            ConfigureContainer.Set(new CastleContainerAdapter(), config);
            return config;
        }
        
        public static Configure CastleContainer(this Configure config, IWindsorContainer windsorContainer)
        {
            ConfigureContainer.Set(new CastleContainerAdapter(windsorContainer), config);
            return config;
        }
        
        public static Configure With_CastleContainer(this Configure config)
        {
            return config.CastleContainer();
        }
        
        public static Configure With_CastleContainer(this Configure config, IWindsorContainer windsorContainer)
        {
            return config.CastleContainer(windsorContainer);
        }
    }
}