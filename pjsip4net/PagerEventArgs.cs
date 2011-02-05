using System;

namespace pjsip4net
{
    public class PagerEventArgs : EventArgs
    {
        public PagerEventArgs(string from, string to, string contact, string mime, int callId, string body)
        {
            From = from;
            To = to;
            Contact = contact;
            MimeType = mime;
            CallId = callId;
            Body = body;
        }

        public string From { get; private set; }
        public string To { get; private set; }
        public string Contact { get; private set; }
        public string MimeType { get; private set; }
        public int CallId { get; private set; }
        public string Body { get; private set; }
    }
}