using System;
using pjsip4net.Core.Data;

namespace pjsip4net.IM
{
    public class BuddyStateChangedEventArgs : EventArgs
    {
        public int Id { get; internal set; }
        public string Uri { get; internal set; }
        public string StatusText { get; internal set; }
        public BuddyStatus Status { get; internal set; }
        public string Note { get; internal set; }
    }
}