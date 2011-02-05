using pjsip4net.Core.Configuration;

namespace pjsip4net.Configuration
{
    public static class ConfigureFromConfig
    {
        public static Configure FromConfig(this Configure cfg)
        {
            cfg.With(new CfgFileConfigurationProvider());
            return cfg;
        }
    }
}