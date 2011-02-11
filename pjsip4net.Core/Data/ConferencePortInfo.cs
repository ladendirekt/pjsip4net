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

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (ConferencePortInfo)) return false;
            return Equals((ConferencePortInfo) obj);
        }

        public bool Equals(ConferencePortInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.SlotId == SlotId && Equals(other.Name, Name) && other.ClockRate == ClockRate &&
                   other.ChannelCount == ChannelCount && other.SamplesPerFrame == SamplesPerFrame &&
                   other.BitsPerSample == BitsPerSample;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = SlotId;
                result = (result*397) ^ (Name != null ? Name.GetHashCode() : 0);
                result = (result*397) ^ ClockRate.GetHashCode();
                result = (result*397) ^ ChannelCount.GetHashCode();
                result = (result*397) ^ SamplesPerFrame.GetHashCode();
                result = (result*397) ^ BitsPerSample.GetHashCode();
                return result;
            }
        }
    }
}