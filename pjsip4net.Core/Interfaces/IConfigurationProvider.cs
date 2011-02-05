using pjsip4net.Core.Data;

namespace pjsip4net.Core.Interfaces
{
    public interface IConfigurationProvider
    {
        void Configure(IConfigurationContext context);
        //void Store(UaConfig config, MediaConfig mediaConfig, LoggingConfig loggingConfig);
    }
}