using System;
using pjsip4net.Core.Data;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls
{
    public class CallTransferEventArgs : EventArgs
    {
        public string Destination { get; internal set; }
        public SipStatusCode StatusCode { get; set; }
        public ICall Call { get; internal set; }
    }
}