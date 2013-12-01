using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Interfaces;

namespace pjsip4net.Transport
{
    public class DefaultVoIPTransportFactory : IVoIPTransportFactory
    {
        private ITransportApiProvider _provider;

        public DefaultVoIPTransportFactory(ITransportApiProvider provider)
        {
            _provider = provider;
        }

        #region Implementation of IVoIPTransportFactory

        public IVoIPTransport CreateTransport(TransportType transportType)
        {
            switch (transportType)
            {
                case TransportType.Udp:
                    return new UdpTransport(_provider);
                case TransportType.Tcp:
                    return new TcpTransport(_provider);
                case TransportType.Tls:
                    return new TlsTransport(_provider);
                default:
                    return new UdpTransport(_provider);
            }
        }

        public IVoIPTransport CreateTransport(TransportType transportType, TransportConfig config)
        {
            var tpt = CreateTransport(transportType);
            using (((Initializable)tpt).InitializationScope())
                if (config != null) tpt.SetConfig(config);
            return tpt;
        }

        #endregion
    }
}