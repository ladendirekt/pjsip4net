using pjsip4net.Core.Configuration;

namespace pjsip.Interop
{
    public static class ConfigureVersion_1_4
    {
        public static Configure WithVersion_1_4(this Configure cfg)
        {
            return cfg.AddComponentConfigurator(new Version_1_4_ComponentConfigurator());
        }
    }
}