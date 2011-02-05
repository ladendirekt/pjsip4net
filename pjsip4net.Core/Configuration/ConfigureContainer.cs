using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;

namespace pjsip4net.Core.Configuration
{
    public static class ConfigureContainer
    {
        public static void Set(IContainer container, Configure config)
        {
            Helper.GuardNotNull(container);
            config.Container = container;
        }
    }
}