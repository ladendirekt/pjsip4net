using pjsip4net.Core;
using pjsip4net.Core.Interfaces.ApiProviders;

namespace pjsip4net.Transport
{
    internal class TcpTransport : VoIPTransport
    {
        public TcpTransport(ITransportApiProvider transportApiProvider)
            : base(transportApiProvider)
        {
            _transportType = TransportType.Tcp;
        }
    }
}