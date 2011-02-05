using System.Configuration;

namespace pjsip4net.Configuration
{
    public class StunElement : ConfigurationElement
    {
        //private ConfigurationProperty _domainProp = new ConfigurationProperty("domain", typeof(string), "");
        private readonly ConfigurationProperty _hostProp = new ConfigurationProperty("address", typeof (string), "");
        private readonly ConfigurationPropertyCollection _properties;

        //[ConfigurationProperty("domain", DefaultValue = "", IsRequired = false)]
        //public string Domain
        //{
        //    get { return base[_domainProp].ToString(); }
        //    set { base[_domainProp] = value; }
        //}

        public StunElement()
        {
            _properties = new ConfigurationPropertyCollection
                              {
                                  //_domainProp,
                                  _hostProp
                              };
        }

        [ConfigurationProperty("address", DefaultValue = "", IsRequired = true)]
        public string Address
        {
            get { return base[_hostProp].ToString(); }
            set { base[_hostProp] = value; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return _properties; }
        }
    }
}