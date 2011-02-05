namespace pjsip4net.Core.Data.Events
{
    public class IncomingTypingRecieved
    {
        public int CallId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Contact { get; set; }
        public bool IsTyping { get; set; }
    }
}