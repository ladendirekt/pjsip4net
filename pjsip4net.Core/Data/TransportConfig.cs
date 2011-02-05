namespace pjsip4net.Core.Data
{
    public class TransportConfig
    {
        public uint Port { get; set; }
        public string PublicAddress { get; set; }
        public string BoundAddress { get; set; }
        public TlsConfig TlsSetting { get; set; }

        public TransportConfig()
        {
            TlsSetting = new TlsConfig();
        }
    }
}