namespace pjsip4net.Core.Data.Events
{
    public class CallTransferRequested : StateChanged
    {
        public string Destination { get; set; }
        public SipStatusCode Status { get; set; }
    }
}