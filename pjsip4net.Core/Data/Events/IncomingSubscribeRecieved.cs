namespace pjsip4net.Core.Data.Events
{
    public class IncomingSubscribeRecieved
    {
        public int AccountId { get; set; }
        public int BuddyId { get; set; }
        public string From { get; set; }
        public SipStatusCode Status { get; set; }
        public string Reason { get; set; }
    }
}