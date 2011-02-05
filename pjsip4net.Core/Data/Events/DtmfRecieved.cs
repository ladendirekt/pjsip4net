namespace pjsip4net.Core.Data.Events
{
    public class DtmfRecieved : StateChanged
    {
        public int Digit { get; set; }
    }
}