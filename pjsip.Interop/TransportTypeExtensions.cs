using System;
using pjsip4net.Core;

namespace pjsip.Interop
{
    
    public static class TransportTypeExtensions
    {
        public static pjsip_transport_type_e ToPjSipTransportType(this TransportType transportType)
        {
            switch (transportType)
            {
                case TransportType.Udp:
                    return pjsip_transport_type_e.PJSIP_TRANSPORT_UDP;
                case TransportType.Tcp:
                    return pjsip_transport_type_e.PJSIP_TRANSPORT_TCP;
                case TransportType.Tls:
                    return pjsip_transport_type_e.PJSIP_TRANSPORT_TLS;
                default:
                    return pjsip_transport_type_e.PJSIP_TRANSPORT_UNSPECIFIED;
            }
        }

        public static TransportType ToTransportType(this pjsip_transport_type_e transportType)
        {
            switch (transportType)
            {
                case pjsip_transport_type_e.PJSIP_TRANSPORT_UDP:
                    return TransportType.Udp;
                case pjsip_transport_type_e.PJSIP_TRANSPORT_TCP:
                    return TransportType.Tcp;
                case pjsip_transport_type_e.PJSIP_TRANSPORT_TLS:
                    return TransportType.Tls;
                default: throw new InvalidOperationException("There is no corresponding TransportType enum value");
            }
        }
    }
}