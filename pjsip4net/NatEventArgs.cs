using System;
using pjsip4net.Core.Data;
using pjsip4net.Core.Data.Events;

namespace pjsip4net
{
    public class NatEventArgs : EventArgs
    {
        internal NatEventArgs(NatDetected result)
        {
            StatusText = result.StatusText;
            NatType = result.NatType;
            NatTypeName = result.NatName;
        }

        public string StatusText { get; set; }
        public NatType NatType { get; set; }
        public string NatTypeName { get; set; }
    }
}