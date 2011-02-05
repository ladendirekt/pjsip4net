using System;

namespace pjsip4net.Core.Data
{
    public class CallInfo
    {
        public int Id { get; set; }
        public SipRole Role { get; set; }
        public int AccId { get; set; }
        public string LocalInfo { get; set; }
        public string LocalContact { get; set; }
        public string RemoteInfo { get; set; }
        public string RemoteContact { get; set; }
        public string CallId { get; set; }
        public InviteState State { get; set; }
        public string StateText { get; set; }
        public SipStatusCode LastStatus { get; set; }
        public string LastStatusText { get; set; }
        public CallMediaState MediaStatus { get; set; }
        public MediaDirection MediaDir { get; set; }
        public int ConfSlot { get; set; }
        public TimeSpan ConnectDuration { get; set; }
        public TimeSpan TotalDuration { get; set; }
    }
}