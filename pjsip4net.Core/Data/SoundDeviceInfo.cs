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
    }
}