namespace pjsip4net.Core.Data.Events
{
    public class ImStatusChanged : StateChanged
    {
        public string To { get; set; }
        public string Body { get; set; }
        public SipStatusCode Status { get; set; }
        public string Reason { get; set; }
    }
}