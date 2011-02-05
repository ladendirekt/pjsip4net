using System.Configuration;

namespace pjsip4net.Configuration
{
    public class DnsServerElement : ConfigurationElement
    {
        private static ConfigurationProperty _addressProp;
        private readonly ConfigurationPropertyCollection _properties;

        public DnsServerElement()
        {
            _addressProp = new ConfigurationProperty("address", typeof (string), "",
                                                     ConfigurationPropertyOptions.IsRequired);
            _properties = new ConfigurationPropertyCollection
                              {
                                  _addressProp
                              };
        }

        [ConfigurationProperty("address", DefaultValue = "", IsRequired = true)]
        public string Address
        {
            get { return base[_addressProp].ToString(); }
            set { base[_addressProp] = value; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return _properties; }
        }
    }
}