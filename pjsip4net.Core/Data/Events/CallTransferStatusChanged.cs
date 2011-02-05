namespace pjsip4net.Core.Data.Events
{
    public class CallTransferStatusChanged : StateChanged
    {
        public int Status { get; set; }
        public string StatusText { get; set; }
        public bool Final { get; set; }
        public bool Continue { get; set; }
    }
}