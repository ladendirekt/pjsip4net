using System.ComponentModel;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Interfaces
{
    public interface IVoIPTransport : IIdentifiable<IVoIPTransport>, ISupportInitialize, IInitializable
    {
        TransportType TransportType { get ; }
        //uint Port { get; set; }
        //string PublicAddress { get; set; }
        //string BoundAddress { get; set; }
        string TransportName { get; }
        string TransportDescription { get; }
        bool? IsReliable { get; }
        bool? IsSecure { get; }
        TransportConfig Config { get; }

        void SetConfig(TransportConfig config);
        void SetId(int id);
    }

    internal interface IVoIPTransportInternal : IVoIPTransport, IResource
    { }
}