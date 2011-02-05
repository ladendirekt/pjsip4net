using System;

namespace pjsip4net.Calls
{
    public class IncomingCallEventArgs : EventArgs
    {
        public IncomingCallEventArgs(string from)
        {
            From = from;
        }

        public string From { get; private set; }
        public bool Accept { get; set; }
    }
}