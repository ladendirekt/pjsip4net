namespace pjsip4net.Core.Data
{
    public class TransportInfo
    {
        public int Id { get; set; }
        public TransportType Type { get; set; }
        public string TypeName { get; set; }
        public string Info { get; set; }
        public uint Flag { get; set; }
        public uint AddrLen { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public uint UsageCount { get; set; }
    }
}