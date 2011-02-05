using Castle.Windsor;
using pjsip4net.Core.Configuration;

namespace pjsip4net.Container.Castle
{
    public static class ConfigureCastleContainer
    {
        public static Configure CastleContainer(this Configure config)
        {
            ConfigureContainer.Set(new CastleContainer(), config);
            return config;
        }
        
        public static Configure CastleContainer(this Configure config, IWindsorContainer windsorContainer)
        {
            ConfigureContainer.Set(new CastleContainer(windsorContainer), config);
            return config;
        }
    }
}