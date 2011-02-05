namespace pjsip4net.Core.Data
{
    public class BuddyInfo
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public string Contact { get; set; }
        public BuddyStatus Status { get; set; }
        public string StatusText { get; set; }
        public bool MonitorPresence { get; set; }
        public SubscriptionState SubState { get; set; }
        public string SubscriptionStateName { get; set; }
        public string SubTermReason { get; set; }
        public RpidElement Rpid { get; set; }
        //public pjsip_pres_status pres_status { get; set; }
        /// char[512]
        public string Buffer { get; set; }
    }
}