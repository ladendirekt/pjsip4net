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
        private IConferenceBridge _conferenceBridge;
        private IMediaApiProvider _mediaApi;
        private ILocalRegistry _registry;
        //private static MediaManager _instance;

        public DefaultMediaManager(IConferenceBridge conferenceBridge, IMediaApiProvider mediaApi, ILocalRegistry registry)
        {
            Helper.GuardNotNull(conferenceBridge);
            Helper.GuardNotNull(mediaApi);
            Helper.GuardNotNull(registry);
            _conferenceBridge = conferenceBridge;
            _registry = registry;
            _mediaApi = mediaApi;

            //SetDevices();
        }

        #region Private Data

        private SoundDeviceInfo _curCapture;
        private SoundDeviceInfo _curPlayback;
        private bool _muted;

        #endregion

        #region Properties

        private ReadOnlyCollection<CodecInfo> _codecs;

        private ReadOnlyCollection<SoundDeviceInfo> _sndDevs;
        public WavPlayer Ringer { get; set; }
        public WavPlayer CallbackRinger { get; set; }
        public WavPlayer BusyRinger { get; set; }
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

        //private int _outDev = 0;
        //public SoundDevice PlaybackDevice
        //{
        //    get
        //    {
        //        int outDev = -1, captDev = -1;
        //        Helper.GuardError(PJSUA_DLL.Media.pjsua_get_snd_dev(ref captDev, ref outDev));
        //        _outDev = outDev;
        //        _captDev = captDev;
        //        return _captDev != NativeConstants.PJSUA_INVALID_ID ? SoundDevices[_outDev] : null;
        //    }
        //    set
        //    {
        //        Helper.GuardNotNull(value);
        //        Helper.GuardInRange(1u, 100u, value.OutputCount);
        //        Helper.GuardPositiveInt(SoundDevices.IndexOf(value));
        //        _outDev = SoundDevices.IndexOf(value);
        //        Helper.GuardError(PJSUA_DLL.Media.pjsua_set_snd_dev(_captDev, _outDev));
        //    }
        //}

        //private int _captDev = 0;
        //public SoundDevice CaptureDevice
        //{
        //    get
        //    {
        //        int outDev = -1, captDev = -1;
        //        Helper.GuardError(PJSUA_DLL.Media.pjsua_get_snd_dev(ref captDev, ref outDev));
        //        _outDev = outDev;
        //        _captDev = captDev;
        //        return _captDev != NativeConstants.PJSUA_INVALID_ID ? SoundDevices[_captDev] : null;
        //    }
        //    set
        //    {
        //        Helper.GuardNotNull(value);
        //        Helper.GuardInRange(1u, 100u, value.InputCount);
        //        Helper.GuardPositiveInt(SoundDevices.IndexOf(value));
        //        _captDev = SoundDevices.IndexOf(value);
        //        Helper.GuardError(PJSUA_DLL.Media.pjsua_set_snd_dev(_captDev, _outDev));
        //    }
        //}

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

        internal void CreateRingers()
        {
            //Ringer = new WavPlayer(@"Sounds\old-phone-ring6.wav", true);
            //CallbackRinger = new WavPlayer(@"Sounds\ring.wav", true);
            //BusyRinger = new WavPlayer(@"Sounds\busy.wav", true);
        }

        public void SetDevices()
        {
            //if (_curCapture == null && _curPlayback == null)
            {
                _curCapture = _registry.MediaConfig.CaptureDeviceId != -1
                                  ? SoundDevices.Where(s => s.Id == _registry.MediaConfig.CaptureDeviceId).Take(1).SingleOrDefault()
                                  : null;
                _curPlayback = _registry.MediaConfig.PlaybackDeviceId != -1
                                   ? SoundDevices.Where(s => s.Id == _registry.MediaConfig.PlaybackDeviceId).Take(1).SingleOrDefault()
                                   : null;
            }

            if (_curCapture != null && _curPlayback != null)
                _mediaApi.SetCurrentSoundDevices(new Tuple<int, int>(_curCapture.Id, _curPlayback.Id));
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

        //internal static MediaManager Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            lock(_lock)
        //                if (_instance == null)
        //                    _instance = new MediaManager();
        //        return _instance;
        //    }
        //}

        //#endregion
    }
}