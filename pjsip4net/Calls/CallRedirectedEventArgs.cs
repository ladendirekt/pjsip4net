using System;
using pjsip4net.Core.Data;

namespace pjsip4net.Calls
{
    public class CallRedirectedEventArgs : EventArgs
    {
        public int CallId { get; internal set; }
        public string Target { get; internal set; }
        public RedirectOption Option { get; set; }
    }
}