using System.Configuration;
using pjsip4net.Transport;

namespace pjsip4net.Configuration
{
    public class SipTransportConfigurationElement : ConfigurationElement
    {
        private readonly ConfigurationProperty _portProp =
            new ConfigurationProperty("Port", typeof (int), 5060, null,
                                      new IntegerValidator(0, 65536, false),
                                      ConfigurationPropertyOptions.None);

        private readonly ConfigurationPropertyCollection _properties;

        private readonly ConfigurationProperty _ttypeProp =
            new ConfigurationProperty("type", typeof (string), "udp", null,
                                      new CallbackValidator(typeof (string),
                                          ValidateTransportType),
                                      ConfigurationPropertyOptions.IsRequired);

        private readonly ConfigurationProperty _boundAddressProp =
           new ConfigurationProperty("boundAddress", typeof(string), "0.0.0.0", null,
                                     new RegexStringValidator(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$"),
                                     ConfigurationPropertyOptions.None);

        private readonly ConfigurationProperty _publicAddressProp =
           new ConfigurationProperty("publicAddress", typeof(string), "0.0.0.0", null,
                                     new RegexStringValidator(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$"),
                                     ConfigurationPropertyOptions.None);

        public SipTransportConfigurationElement()
        {
            _properties = new ConfigurationPropertyCollection
                              {
                                  _ttypeProp,
                                  _portProp,
                                  _boundAddressProp,
                                  _publicAddressProp
                              };
        }

        [ConfigurationProperty("type", DefaultValue = "udp", IsRequired = true)]
        [CallbackValidator(CallbackMethodName = "ValidateTransportType")]
        public string TransportType
        {
            get { return base[_ttypeProp].ToString(); }
            set { base[_ttypeProp] = value; }
        }

        [ConfigurationProperty("port", DefaultValue = 5060)]
        [IntegerValidator(ExcludeRange = false, MaxValue = 65536, MinValue = 0)]
        public int Port
        {
            get { return (int) base[_portProp]; }
            set { base[_portProp] = value; }
        }

        [ConfigurationProperty("boundAddress", DefaultValue = "0.0.0.0")]
        [RegexStringValidator(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$")]
        public string BoundAddress
        {
            get { return base[_boundAddressProp].ToString(); }
            set { base[_boundAddressProp] = value; }
        }

        [ConfigurationProperty("publicAddress", DefaultValue = "0.0.0.0")]
        [RegexStringValidator(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$")]
        public string PublicAddress
        {
            get { return base[_publicAddressProp].ToString(); }
            set { base[_publicAddressProp] = value; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return _properties; }
        }

        internal static void ValidateTransportType(object value)
        {
            string v = value.ToString();
            if (!(v.Equals("udp") || v.Equals("tcp") || v.Equals("tls")))
                throw new ConfigurationErrorsException(
                    "Wrong SIP transport type. Can be one of following: udp, tcp, tls");
        }
    }
}
