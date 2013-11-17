using pjsip4net.Core.Configuration;

namespace pjsip4net.Testing
{
    public static class ConfigureForTest
    {
        public static Configure WithVersion_For_Tests(this Configure configure)
        {
            return configure.With(new TestConfigurator());
        }
    }
}
