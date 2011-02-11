using System.Collections.Generic;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Core.Interfaces
{
    /// <summary>
    /// Contextual data for external configuration provider.
    /// </summary>
    public interface IConfigurationContext
    {
        UaConfig Config { get; }
        LoggingConfig LoggingConfig { get; }
        MediaConfig MediaConfig { get; }
        void RegisterTransport(Tuple<TransportType, TransportConfig> sipTransportConfig);
        void RegisterAccounts(IEnumerable<AccountConfig> accountConfigs);
    }
}