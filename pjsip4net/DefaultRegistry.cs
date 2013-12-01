using System.Collections.Generic;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;
using pjsip4net.Transport;

namespace pjsip4net
{
    internal class DefaultRegistry : IRegistry, IConfigurationContext
    {
        #region Implementation of ILocalRegistry

        public IContainer Container { get; set; }

        public VoIPTransport SipTransport { get; set; }
        public VoIPTransport RtpTransport { get; set; }

        public UaConfig Config { get; set; }
        public MediaConfig MediaConfig { get; set; }
        public LoggingConfig LoggingConfig { get; set; }
        public Core.Utils.Tuple<TransportType, TransportConfig> TransportConfig { get; set; }
        public IEnumerable<AccountConfig> AccountConfigs { get; set; }

        #endregion

        public void RegisterTransport(Core.Utils.Tuple<TransportType, TransportConfig> sipTransportConfig)
        {
            Helper.GuardNotNull(sipTransportConfig);
            TransportConfig = sipTransportConfig;
        }

        public void RegisterAccounts(IEnumerable<AccountConfig> accountConfigs)
        {
            Helper.GuardNotNull(accountConfigs);
            AccountConfigs = accountConfigs;
        }
    }
}