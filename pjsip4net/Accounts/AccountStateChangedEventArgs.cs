using System;
using pjsip4net.Core.Data;

namespace pjsip4net.Accounts
{
    public class AccountStateChangedEventArgs : EventArgs
    {
        public int Id { get; internal set; }
        public string Uri { get; internal set; }
        public string StatusText { get; internal set; }
        public SipStatusCode StatusCode { get; internal set; }
    }
}