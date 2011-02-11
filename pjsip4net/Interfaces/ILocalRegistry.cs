using System.Collections.Generic;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;

namespace pjsip4net.Interfaces
{
    internal interface ILocalRegistry
    {
        IContainer Container { get; set; }
        IVoIPTransportInternal SipTransport { get; set; }
        IVoIPTransportInternal RtpTransport { get; set; }
        UaConfig Config { get; set; }
        MediaConfig MediaConfig { get; set; }
        LoggingConfig LoggingConfig { get; set; }

        Tuple<TransportType, TransportConfig> TransportConfig { get; set; }
        IEnumerable<AccountConfig> AccountConfigs { get; set; }
    }
}