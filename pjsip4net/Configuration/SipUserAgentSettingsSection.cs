using System.Configuration;
using pjsip4net.Core.Data;

namespace pjsip4net.Configuration
{
    public class SipUserAgentSettingsSection : ConfigurationSection
    {
        private static readonly ConfigurationProperty _accountsProp;
        private static readonly ConfigurationProperty _autoAnswer;
        private static readonly ConfigurationProperty _autoConference;
        private static readonly ConfigurationProperty _logLevel;
        private static readonly ConfigurationProperty _logMsgs;
        private static readonly ConfigurationProperty _maxCalls;
        private static readonly ConfigurationProperty _mediaConfigProp;
        private static readonly ConfigurationProperty _netSettingsProp;
        private static readonly ConfigurationPropertyCollection _props;
        private static readonly ConfigurationProperty _secureMediaProp;
        private static readonly ConfigurationProperty _secureSignalingProp;
        private static readonly ConfigurationProperty _traceAndDebugProp;
        private static readonly ConfigurationProperty _transportProp;

        static SipUserAgentSettingsSection()
        {
            _accountsProp = new ConfigurationProperty("accounts", typeof (AccountElementsCollection));
            _transportProp = new ConfigurationProperty("sipTransport", typeof (SipTransportConfigurationElement), null,
                                                       ConfigurationPropertyOptions.IsRequired);

            _secureMediaProp = new ConfigurationProperty("srtp", typeof (SrtpRequirement), SrtpRequirement.Disabled);
            _secureSignalingProp = new ConfigurationProperty("secureSignaling", typeof (int), 0);
            _netSettingsProp = new ConfigurationProperty("networkSettings", typeof (NetworkSettingsElement), null);
            _logMsgs = new ConfigurationProperty("logMessages", typeof (bool), true);
            _logLevel = new ConfigurationProperty("logLevel", typeof (int), 4, null, new IntegerValidator(0, 5, false),
                                                  ConfigurationPropertyOptions.None);
            _traceAndDebugProp = new ConfigurationProperty("traceAndDebug", typeof (bool), false);
            _autoAnswer = new ConfigurationProperty("autoAnswer", typeof (bool), false);
            _autoConference = new ConfigurationProperty("autoConference", typeof (bool), false);
            _maxCalls = new ConfigurationProperty("maxCalls", typeof (int), 5);
            _mediaConfigProp = new ConfigurationProperty("media", typeof (MediaConfigurationElement), null,
                                                         ConfigurationPropertyOptions.IsRequired);

            _props = new ConfigurationPropertyCollection
                         {
                             _accountsProp,
                             _transportProp,
                             _secureMediaProp,
                             _secureSignalingProp,
                             _netSettingsProp,
                             _logMsgs,
                             _logLevel,
                             _traceAndDebugProp,
                             _autoAnswer,
                             _autoConference,
                             _maxCalls,
                             _mediaConfigProp
                         };
        }

        [ConfigurationProperty("accounts")]
        public AccountElementsCollection Accounts
        {
            get { return (AccountElementsCollection) base[_accountsProp]; }
            set { base[_accountsProp] = value; }
        }

        [ConfigurationProperty("sipTransport", DefaultValue = null, IsRequired = true)]
        public SipTransportConfigurationElement Transport
        {
            get { return (SipTransportConfigurationElement) base[_transportProp]; }
            set { base[_transportProp] = value; }
        }

        [ConfigurationProperty("srtp", DefaultValue = SrtpRequirement.Disabled)]
        public SrtpRequirement SecureMedia
        {
            get { return (SrtpRequirement) base[_secureMediaProp]; }
            set { base[_secureMediaProp] = value; }
        }

        [ConfigurationProperty("secureSignaling", DefaultValue = 0)]
        [IntegerValidator(ExcludeRange = false, MinValue = 0, MaxValue = 2)]
        public int SecureSignaling
        {
            get { return (int) base[_secureSignalingProp]; }
            set { base[_secureSignalingProp] = value; }
        }

        [ConfigurationProperty("networkSettings", DefaultValue = null, IsRequired = false)]
        public NetworkSettingsElement NetworkSettings
        {
            get { return (NetworkSettingsElement) base[_netSettingsProp]; }
            set { base[_netSettingsProp] = value; }
        }

        [ConfigurationProperty("logMessages", DefaultValue = true)]
        public bool LogMessages
        {
            get { return (bool) base[_logMsgs]; }
            set { base[_logMsgs] = value; }
        }

        [ConfigurationProperty("logLevel", DefaultValue = 4)]
        [IntegerValidator(ExcludeRange = false, MaxValue = 5, MinValue = 0)]
        public int LogLevel
        {
            get { return (int) base[_logLevel]; }
            set { base[_logLevel] = value; }
        }

        [ConfigurationProperty("traceAndDebug", DefaultValue = false)]
        public bool TraceAndDebug
        {
            get { return (bool) base[_traceAndDebugProp]; }
            set { base[_traceAndDebugProp] = value; }
        }

        [ConfigurationProperty("autoAnswer", DefaultValue = false)]
        public bool AutoAnswer
        {
            get { return (bool) base[_autoAnswer]; }
            set { base[_autoAnswer] = value; }
        }

        [ConfigurationProperty("autoConference", DefaultValue = false)]
        public bool AutoConference
        {
            get { return (bool) base[_autoConference]; }
            set { base[_autoConference] = value; }
        }

        [ConfigurationProperty("maxCalls", DefaultValue = 5, IsRequired = false)]
        public int MaxCalls
        {
            get { return (int) base[_maxCalls]; }
            set { base[_maxCalls] = value; }
        }

        [ConfigurationProperty("media", DefaultValue = null, IsRequired = true)]
        public MediaConfigurationElement MediaConfig
        {
            get { return (MediaConfigurationElement) base[_mediaConfigProp]; }
            set { base[_mediaConfigProp] = value; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return _props; }
        }

        public void Copy(SipUserAgentSettingsSection section)
        {
            Accounts = section.Accounts;
            AutoAnswer = section.AutoAnswer;
            AutoConference = section.AutoConference;
            SecureMedia = section.SecureMedia;
            SecureSignaling = section.SecureSignaling;
            NetworkSettings = section.NetworkSettings;
            LogMessages = section.LogMessages;
            LogLevel = section.LogLevel;
            TraceAndDebug = section.TraceAndDebug;
            MediaConfig = section.MediaConfig;
            Transport = section.Transport;
        }
    }
}