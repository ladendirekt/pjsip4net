using System.Configuration;

namespace pjsip4net.Configuration
{
    public class IceElement : ConfigurationElement
    {
        private readonly ConfigurationProperty _enabledProp = new ConfigurationProperty("enabled", typeof (bool), false,
                                                                                        ConfigurationPropertyOptions.
                                                                                            IsRequired);

        //private ConfigurationProperty _noHostCandsProp = new ConfigurationProperty("noHostCandidates", typeof(bool));
        private readonly ConfigurationProperty _noRTCPProp = new ConfigurationProperty("noRTCP", typeof (bool));
        private readonly ConfigurationPropertyCollection _properties;

        public IceElement()
        {
            _properties = new ConfigurationPropertyCollection
                              {
                                  _enabledProp,
                                  //_noHostCandsProp,
                                  _noRTCPProp
                              };
        }

        [ConfigurationProperty("enabled", DefaultValue = false, IsRequired = true)]
        public bool Enabled
        {
            get { return (bool) base[_enabledProp]; }
            set { base[_enabledProp] = value; }
        }

        //[ConfigurationProperty("noHostCandidates", DefaultValue = false, IsRequired = false)]
        //public bool NoHostCandidates
        //{
        //    get { return (bool)base[_noHostCandsProp]; }
        //    set { base[_noHostCandsProp] = value; }
        //}

        [ConfigurationProperty("noRTCP", DefaultValue = false, IsRequired = false)]
        public bool NoRtcp
        {
            get { return (bool) base[_noRTCPProp]; }
            set { base[_noRTCPProp] = value; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return _properties; }
        }
    }
}