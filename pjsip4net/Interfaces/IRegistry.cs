using System.Collections.Generic;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.Transport;

namespace pjsip4net.Interfaces
{
    internal interface IRegistry
    {
        IContainer Container { get; set; }
        VoIPTransport SipTransport { get; set; }
        VoIPTransport RtpTransport { get; set; }
        UaConfig Config { get; set; }
        MediaConfig MediaConfig { get; set; }
        LoggingConfig LoggingConfig { get; set; }

        Tuple<TransportType, TransportConfig> TransportConfig { get; set; }
        IEnumerable<AccountConfig> AccountConfigs { get; set; }
    }
}