namespace pjsip4net.Core.Data
{
    public class AccountInfo
    {
        public int Id { get; set; }
        public int IsDefault { get; set; }
        public string AccUri{ get; set; }
        public int HasRegistration{ get; set; }
        public int Expires{ get; set; }
        public SipStatusCode Status{ get; set; }
        public string StatusText{ get; set; }
        public int OnlineStatus{ get; set; }
        public string OnlineStatusText{ get; set; }
        public RpidElement Rpid{ get; set; }
    }
}