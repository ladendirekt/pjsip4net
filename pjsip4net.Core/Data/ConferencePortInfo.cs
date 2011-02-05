using System.Collections.Generic;

namespace pjsip4net.Core.Data
{
    public class ConferencePortInfo
    {
        public int SlotId { get; set; }
        public string Name { get; set; }
        public uint ClockRate { get; set; }
        public uint ChannelCount { get; set; }
        public uint SamplesPerFrame { get; set; }
        public uint BitsPerSample { get; set; }
        public IList<int> Listeners { get; set; }

        public ConferencePortInfo()
        {
            Listeners = new List<int>();
        }
    }
}