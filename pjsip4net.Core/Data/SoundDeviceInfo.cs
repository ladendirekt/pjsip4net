namespace pjsip4net.Core.Data
{
    public class SoundDeviceInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public uint InputCount { get; set; }
        public uint OutputCount { get; set; }
        public uint DefaultSamplesPerSec { get; set; }
        public bool IsPlayback
        {
            get { return OutputCount > 0; }
        }

        public bool IsCapture
        {
            get { return InputCount > 0; }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (SoundDeviceInfo)) return false;
            return Equals((SoundDeviceInfo) obj);
        }

        public bool Equals(SoundDeviceInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.Id == Id && Equals(other.Name, Name) && other.InputCount == InputCount &&
                   other.OutputCount == OutputCount && other.DefaultSamplesPerSec == DefaultSamplesPerSec;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = Id;
                result = (result*397) ^ (Name != null ? Name.GetHashCode() : 0);
                result = (result*397) ^ InputCount.GetHashCode();
                result = (result*397) ^ OutputCount.GetHashCode();
                result = (result*397) ^ DefaultSamplesPerSec.GetHashCode();
                return result;
            }
        }
    }
}