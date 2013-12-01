using pjsip4net.Core;
using pjsip4net.Core.Interfaces.ApiProviders;

namespace pjsip4net.Transport
{
    internal class UdpTransport : VoIPTransport
    {
        public UdpTransport(ITransportApiProvider transportApiProvider)
            : base(transportApiProvider)
        {
            _transportType = TransportType.Udp;
        }
    }
}