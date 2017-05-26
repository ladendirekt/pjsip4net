using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Media
{
    internal class DefaultMediaManager : Initializable, IMediaManagerInternal
    {
        //#region Singleton

        private static readonly object _lock = new object();
        private readonly IConferenceBridge _conferenceBridge;
        private readonly IMediaApiProvider _mediaApi;
        private readonly IRegistry _registry;

        public DefaultMediaManager(IConferenceBridge conferenceBridge, IMediaApiProvider mediaApi, IRegistry registry)
        {
            Helper.GuardNotNull(conferenceBridge);
            Helper.GuardNotNull(mediaApi);
            Helper.GuardNotNull(registry);
            _conferenceBridge = conferenceBridge;
            _registry = registry;
            _mediaApi = mediaApi;
        }

        #region Private Data

        private SoundDeviceInfo _curCapture;
        private SoundDeviceInfo _curPlayback;
        private bool _muted;

        #endregion

        #region Properties

        private ReadOnlyCollection<CodecInfo> _codecs;
        private ReadOnlyCollection<SoundDeviceInfo> _sndDevs;
        
        public IMediaApiProvider Provider
        {
            get { return _mediaApi; }
        }

        public IConferenceBridge ConferenceBridge
        {
            get { return _conferenceBridge; }
        }

        public ReadOnlyCollection<CodecInfo> Codecs
        {
            get
            {
                if (_codecs == null)
                    lock (_lock)
                        if (_codecs == null)
                        {
                            _codecs = new ReadOnlyCollection<CodecInfo>(_mediaApi.EnumerateCodecs().ToList());
                        }
                return _codecs;
            }
        }

        public ReadOnlyCollection<SoundDeviceInfo> SoundDevices
        {
            get
            {
                if (_sndDevs == null)
                    lock (_lock)
                        if (_sndDevs == null)
                        {
                            _sndDevs = new ReadOnlyCollection<SoundDeviceInfo>(_mediaApi.EnumerateSoundDevices().ToList());
                        }
                return _sndDevs;
            }
        }

        public IEnumerable<SoundDeviceInfo> PlaybackDevices
        {
            get { return SoundDevices.Where(s => s.IsPlayback).Distinct(new ByNameEqualityComparer()); }
        }

        public IEnumerable<SoundDeviceInfo> CaptureDevices
        {
            get { return SoundDevices.Where(s => s.IsCapture).Distinct(new ByNameEqualityComparer()); }
        }

        public SoundDeviceInfo CurrentPlaybackDevice
        {
            get { return _curPlayback; }
        }

        public SoundDeviceInfo CurrentCaptureDevice
        {
            get { return _curCapture; }
        }

        #endregion

        #region Methods

        public void ToggleMute()
        {
            lock (_lock)
            {
                if (_muted)
                    SetDevices();
                else
                    _mediaApi.SetCurrentSoundDevicesToNull();

                _muted = !_muted;
            }
        }

        public void SetSoundDevices(SoundDeviceInfo playback, SoundDeviceInfo capture)
        {
            SetSoundDevices(playback == null ? -1 : playback.Id, capture == null ? -1 : capture.Id);
        }

        public void SetSoundDevices(int playback, int capture)
        {
            _registry.MediaConfig.CaptureDeviceId = capture;
            _registry.MediaConfig.PlaybackDeviceId = playback;

            SetDevices();
        }

        public void SetDevices()
        {
            _curCapture = _registry.MediaConfig.CaptureDeviceId != -1
                ? SoundDevices.Where(s => s.Id == _registry.MediaConfig.CaptureDeviceId).Take(1).SingleOrDefault()
                : null;
            _curPlayback = _registry.MediaConfig.PlaybackDeviceId != -1
                ? SoundDevices.Where(s => s.Id == _registry.MediaConfig.PlaybackDeviceId).Take(1).SingleOrDefault()
                : null;

            if (_curCapture != null && _curPlayback != null)
                _mediaApi.SetCurrentSoundDevices(new Tuple<int, int>(_curCapture.Id, _curPlayback.Id));
            else if (_curCapture == null && _curPlayback != null)
                _mediaApi.SetCurrentSoundDevices(new Tuple<int, int>(-1, _curPlayback.Id));
			else if (_curCapture != null && _curPlayback == null)
                _mediaApi.SetCurrentSoundDevices(new Tuple<int, int>(_curCapture.Id, -1));
            else
                _mediaApi.SetCurrentSoundDevicesToNull();
        }

        #endregion

        #region Nested type: ByNameEqualityComparer

        private class ByNameEqualityComparer : IEqualityComparer<SoundDeviceInfo>, IEqualityComparer
        {
            #region Implementation of IEqualityComparer<SoundDevice>

            public bool Equals(SoundDeviceInfo x, SoundDeviceInfo y)
            {
                return x.Name.Equals(y.Name);
            }

            public int GetHashCode(SoundDeviceInfo obj)
            {
                return obj.Name.GetHashCode();
            }

            #endregion

            #region Implementation of IEqualityComparer

            public bool Equals(object x, object y)
            {
                return Equals((SoundDeviceInfo) x, (SoundDeviceInfo) y);
            }

            public int GetHashCode(object obj)
            {
                return GetHashCode((SoundDeviceInfo) obj);
            }

            #endregion
        }

        #endregion
    }
}
