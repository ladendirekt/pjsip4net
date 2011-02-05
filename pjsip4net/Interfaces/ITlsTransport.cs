using pjsip4net.Core.Interfaces;

namespace pjsip4net.Interfaces
{
    public interface ITlsTransport : IVoIPTransport
    {
        string CAListFile { get; set; }
        string CertificateFile { get; set; }
        string PrivateKeyFile { get; set; }
        bool VerifyServer { get; set; }
        bool VerifyClient { get; set; }
        bool RequireClientCertificate { get; set; }
    }
}