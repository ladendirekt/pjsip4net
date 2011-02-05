namespace pjsip4net.Core.Data.Events
{
    public class CallRedirected : StateChanged
    {
        public string Target { get; set; }
        public RedirectOption Option { get; set; }
    }
}