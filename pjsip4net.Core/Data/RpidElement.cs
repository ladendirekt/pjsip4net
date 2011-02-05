namespace pjsip4net.Core.Data
{
    public class RpidElement
    {
        public string Id { get; set; }
        public RpidActivity Activity { get; set; }
        public string Note { get; set; }
    }

    public enum RpidActivity
    {
        Unknown,
        Away,
        Busy,
    }
}