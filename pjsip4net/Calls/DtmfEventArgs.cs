using System;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls
{
    public class DtmfEventArgs : EventArgs
    {
        public DtmfEventArgs(ICall call, int digit)
        {
            Helper.GuardNotNull(call);
            Helper.GuardPositiveInt(call.Id);

            Digit = Convert.ToChar(digit);
            CallId = call.Id;
        }

        public char Digit { get; private set; }
        public int CallId { get; private set; }
    }
}