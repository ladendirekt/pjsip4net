using System.Configuration;

namespace pjsip4net.Configuration
{
    public class NetworkSettingsElement : ConfigurationElement
    {
        private readonly ConfigurationProperty _dnsServersProp = new ConfigurationProperty("dnsServers",
                                                                                           typeof (
                                                                                               DnsServerElementsCollection
                                                                                               ));

        private readonly ConfigurationProperty _forceLRProp = new ConfigurationProperty("forceLooseRoute", typeof (bool));
        private readonly ConfigurationProperty _iceProp = new ConfigurationProperty("ice", typeof (IceElement));
        private readonly ConfigurationProperty _natInSDPProp = new ConfigurationProperty("natInSDP", typeof (bool));
        private readonly ConfigurationPropertyCollection _properties;

        private readonly ConfigurationProperty _proxiesProp = new ConfigurationProperty("proxies",
                                                                                        typeof (ProxyElementsCollection));

        private readonly ConfigurationProperty _stunProp = new ConfigurationProperty("stun", typeof (StunElement));

        private readonly ConfigurationProperty _stunSvcProp = new ConfigurationProperty("stunServers",
                                                                                        typeof (
                                                                                            StunServerElementsCollection
                                                                                            ));

        private readonly ConfigurationProperty _turnProp = new ConfigurationProperty("turn", typeof (TurnElement));

        public NetworkSettingsElement()
        {
            _properties = new ConfigurationPropertyCollection
                              {
                                  _natInSDPProp,
                                  _forceLRProp,
                                  _dnsServersProp,
                                  _proxiesProp,
                                  _stunProp,
                                  _stunSvcProp,
                                  _turnProp,
                                  _iceProp
                              };
        }

        [ConfigurationProperty("natInSDP", DefaultValue = false, IsRequired = false)]
        public bool NatInSdp
        {
            get { return (bool) base[_natInSDPProp]; }
            set { base[_natInSDPProp] = value; }
        }

        [ConfigurationProperty("forceLooseRoute", DefaultValue = false, IsRequired = false)]
        public bool ForceLooseRoute
        {
            get { return (bool) base[_forceLRProp]; }
            set { base[_forceLRProp] = value; }
        }

        [ConfigurationProperty("dnsServers")]
        public DnsServerElementsCollection DnsServers
        {
            get { return (DnsServerElementsCollection) base[_dnsServersProp]; }
            set { base[_dnsServersProp] = value; }
        }

        [ConfigurationProperty("proxies")]
        public ProxyElementsCollection Proxies
        {
            get { return (ProxyElementsCollection) base[_proxiesProp]; }
            set { base[_proxiesProp] = value; }
        }

        [ConfigurationProperty("stun", DefaultValue = null, IsRequired = false)]
        public StunElement Stun
        {
            get { return (StunElement) base[_stunProp]; }
            set { base[_stunProp] = value; }
        }

        [ConfigurationProperty("stunServers", DefaultValue = null, IsRequired = false)]
        public StunServerElementsCollection StunServers
        {
            get { return (StunServerElementsCollection) base[_stunSvcProp]; }
            set { base[_stunSvcProp] = value; }
        }

        [ConfigurationProperty("turn", DefaultValue = null, IsRequired = false)]
        public TurnElement Turn
        {
            get { return (TurnElement) base[_turnProp]; }
            set { base[_turnProp] = value; }
        }

        [ConfigurationProperty("ice", DefaultValue = null, IsRequired = false)]
        public IceElement ICE
        {
            get { return (IceElement) base[_iceProp]; }
            set { base[_iceProp] = value; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return _properties; }
        }
    }
}