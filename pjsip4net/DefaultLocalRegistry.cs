using System;
using System.Collections.Generic;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net
{
    internal class DefaultLocalRegistry : ILocalRegistry, IConfigurationContext
    {
        #region Implementation of ILocalRegistry

        public IContainer Container { get; set; }

        public IVoIPTransportInternal SipTransport { get; set; }
        public IVoIPTransportInternal RtpTransport { get; set; }

        public UaConfig Config { get; set; }
        public MediaConfig MediaConfig { get; set; }
        public LoggingConfig LoggingConfig { get; set; }
        public Tuple<TransportType, TransportConfig> TransportConfig { get; set; }
        public IEnumerable<AccountConfig> AccountConfigs { get; set; }

        #endregion

        public void RegisterTransport(Tuple<TransportType, TransportConfig> sipTransportConfig)
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