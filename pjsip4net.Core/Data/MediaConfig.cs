using System;
using System.Net;

namespace pjsip4net.Core.Data
{
    public class MediaConfig : Initializable
    {
        public int CaptureDeviceId = -1,
                   PlaybackDeviceId = -1;

        #region Properties

        public uint ClockRate { get; set; }
        public uint SndClockRate { get; set; }
        public uint ChannelCount { get; set; }
        public uint AudioFramePtime { get; set; }
        public uint MaxMediaPorts { get; set; }
        public bool HasIOQueue { get; set; }
        public uint ThreadCnt { get; set; }
        public uint Quality { get; set; }
        public bool IsVadEnabled { get; set; }
        public uint ILBCMode { get; set; }
        public uint EcOptions { get; set; }
        public uint EcTailLen { get; set; }
        public bool EnableICE { get; set; }
        public bool ICENoRtcp { get; set; }
        public bool EnableTurn { get; set; }
        public string TurnServer { get; set; }
        public TransportType TurnConnectionType { get; set; }
        public NetworkCredential TurnAuthentication { get; set; }
        public TimeSpan SoundDeviceAutoCloseTime { get; set; }

        #endregion
    }
}