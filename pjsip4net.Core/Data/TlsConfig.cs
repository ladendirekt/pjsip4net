using System;

namespace pjsip4net.Core.Data
{
    public class TlsConfig
    {
        public string CAListFile {get; set; }
        public string CertFile {get; set; }
        public string PrivKeyFile {get; set; }
        public string Password {get; set; }
        public int Method {get; set; }
        public string Ciphers {get; set; }
        public string ServerName {get; set; }
        public bool VerifyServer {get; set; }
        public bool VerifyClient {get; set; }
        public bool RequireClientCert {get; set; }
        public TimeSpan Timeout {get; set; }
    }
}