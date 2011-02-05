namespace pjsip4net.Core.Data.Events
{
    public class NatDetected
    {
        public int Status { get; set; }
        public string StatusText { get; set; }
        public NatType NatType { get; set; }
        public string NatName { get; set; }
    }
}