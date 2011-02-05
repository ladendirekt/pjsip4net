using System.Configuration;

namespace pjsip4net.Configuration
{
    public class TurnElement : ConfigurationElement
    {
        private readonly ConfigurationProperty _enabledProp = new ConfigurationProperty("enabled", typeof (bool), false,
                                                                                        ConfigurationPropertyOptions.
                                                                                            IsRequired);

        private readonly ConfigurationProperty _passwordProp = new ConfigurationProperty("password", typeof (string), "");
        private readonly ConfigurationPropertyCollection _properties;
        private readonly ConfigurationProperty _realmProp = new ConfigurationProperty("realm", typeof (string), "");

        private readonly ConfigurationProperty _serverProp = new ConfigurationProperty("server", typeof (string), "",
                                                                                       ConfigurationPropertyOptions.
                                                                                           IsRequired);

        private readonly ConfigurationProperty _ttypeProp = new ConfigurationProperty("type", typeof (string), "udp",
                                                                                      null,
                                                                                      new CallbackValidator(
                                                                                          typeof (string),
                                                                                          SipTransportConfigurationElement
                                                                                              .ValidateTransportType),
                                                                                      ConfigurationPropertyOptions.
                                                                                          IsRequired);

        private readonly ConfigurationProperty _usernameProp = new ConfigurationProperty("userName", typeof (string), "");

        public TurnElement()
        {
            _properties = new ConfigurationPropertyCollection
                              {
                                  _enabledProp,
                                  _serverProp,
                                  _ttypeProp,
                                  _usernameProp,
                                  _passwordProp,
                                  _realmProp
                              };
        }

        [ConfigurationProperty("enabled", DefaultValue = false, IsRequired = true)]
        public bool Enabled
        {
            get { return (bool) base[_enabledProp]; }
            set { base[_enabledProp] = value; }
        }

        [ConfigurationProperty("server", DefaultValue = "", IsRequired = true)]
        public string Server
        {
            get { return base[_serverProp].ToString(); }
            set { base[_serverProp] = value; }
        }

        [ConfigurationProperty("transportType", DefaultValue = "udp", IsRequired = true)]
        public string TransportType
        {
            get { return base[_ttypeProp].ToString(); }
            set { base[_ttypeProp] = value; }
        }

        [ConfigurationProperty("userName", IsRequired = false)]
        public string UserName
        {
            get { return base[_usernameProp].ToString(); }
            set { base[_usernameProp] = value; }
        }

        [ConfigurationProperty("password", IsRequired = false)]
        public string Password
        {
            get { return base[_passwordProp].ToString(); }
            set { base[_passwordProp] = value; }
        }

        [ConfigurationProperty("realm", IsRequired = false)]
        public string Realm
        {
            get { return base[_realmProp].ToString(); }
            set { base[_realmProp] = value; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return _properties; }
        }
    }
}