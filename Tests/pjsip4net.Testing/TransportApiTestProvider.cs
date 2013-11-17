using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;

namespace pjsip4net.Testing
{
    public class TransportApiTestProvider : ITransportApiProvider
    {
        public TransportConfig GetDefaultConfig()
        {
            return new TransportConfig();
        }

        public int CreateTransportAndGetId(TransportType type, TransportConfig cfg)
        {
            return 0;
        }

        public TransportInfo GetTransportInfo(int id)
        {
            return new TransportInfo();
        }

        public void CloseTransport(int id)
        {
        }

        public void ForceCloseTransport(int id)
        {
        }
    }
}