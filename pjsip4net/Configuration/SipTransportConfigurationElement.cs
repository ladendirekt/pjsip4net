using System.Configuration;
using pjsip4net.Transport;

namespace pjsip4net.Configuration
{
    public class SipTransportConfigurationElement : ConfigurationElement
    {
        private readonly ConfigurationProperty _portProp =
            new ConfigurationProperty("Port", typeof (int), 5060, null,
                                      new IntegerValidator(1, 65536, false),
                                      ConfigurationPropertyOptions.None);

        private readonly ConfigurationPropertyCollection _properties;

        private readonly ConfigurationProperty _ttypeProp =
            new ConfigurationProperty("type", typeof (string), "udp", null,
                                      new CallbackValidator(typeof (string),
                                          ValidateTransportType),
                                      ConfigurationPropertyOptions.IsRequired);

        public SipTransportConfigurationElement()
        {
            _properties = new ConfigurationPropertyCollection
                              {
                                  _ttypeProp,
                                  _portProp
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
        [IntegerValidator(ExcludeRange = false, MaxValue = 65536, MinValue = 1)]
        public int Port
        {
            get { return (int) base[_portProp]; }
            set { base[_portProp] = value; }
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

        //public VoIPTransport CreateTransport()
        //{
        //    VoIPTransport transport;
        //    switch (TransportType)
        //    {
        //        case "udp":
        //            transport = VoIPTransport.CreateUDPTransport();
        //            break;
        //        case "tcp":
        //            transport = VoIPTransport.CreateTCPTransport();
        //            break;
        //        case "tls":
        //            transport = VoIPTransport.CreateTLSTransport();
        //            break;
        //        default:
        //            transport = VoIPTransport.CreateUDPTransport();
        //            break;
        //    }

        //    using (transport.InitializationScope())
        //        transport.Port = (uint) Port;
        //    return transport;
        //}
    }
}