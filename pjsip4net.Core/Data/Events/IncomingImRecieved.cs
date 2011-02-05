namespace pjsip4net.Core.Data.Events
{
    public class IncomingImRecieved
    {
        public int CallId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Contact { get; set; }
        public string MimeType { get; set; }
        public string Body { get; set; }
    }
}