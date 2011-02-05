using System.Collections.Generic;
using System.Collections.ObjectModel;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Media;

namespace pjsip4net.Interfaces
{
    public interface IMediaManager
    {
        IConferenceBridge ConferenceBridge { get; }
        ReadOnlyCollection<CodecInfo> Codecs { get; }
        ReadOnlyCollection<SoundDeviceInfo> SoundDevices { get; }
        IEnumerable<SoundDeviceInfo> PlaybackDevices { get; }
        IEnumerable<SoundDeviceInfo> CaptureDevices { get; }
        SoundDeviceInfo CurrentPlaybackDevice { get; }
        SoundDeviceInfo CurrentCaptureDevice { get; }
        void ToggleMute();
        void SetSoundDevices(SoundDeviceInfo playback, SoundDeviceInfo capture);
        void SetSoundDevices(int playback, int capture);
    }

    internal interface IMediaManagerInternal : IMediaManager, IInitializable
    {
        void SetDevices();
        //void SetConfiguration(MediaConfig mediaConfig);
    }
}