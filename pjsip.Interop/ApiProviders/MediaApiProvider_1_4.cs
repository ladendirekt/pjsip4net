using System;
using System.Collections.Generic;
using System.Linq;
using pjsip.Interop.Interfaces;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;

namespace pjsip.Interop.ApiProviders
{
    public class MediaApiProvider_1_4 : IMediaApiProvider
    {
        private IMapper _mapper;

        public MediaApiProvider_1_4(IMapper mapper)
        {
            Helper.GuardNotNull(mapper);
            _mapper = mapper;
        }

        #region Implementation of IMediaApiProvider

        public MediaConfig GetDefaultConfig()
        {
            var cfg = new pjsua_media_config();
            PJSUA_DLL.Media.pjsua_media_config_default(cfg);
            return _mapper.Map(cfg, new MediaConfig());
        }

        public uint GetMaxConferencePorts()
        {
            return PJSUA_DLL.Media.pjsua_conf_get_max_ports();
        }

        public uint GetActivePortsCount()
        {
            return PJSUA_DLL.Media.pjsua_conf_get_active_ports();
        }

        public ConferencePortInfo GetPortInfo(int portId)
        {
            Helper.GuardPositiveInt(portId);
            var info = new pjsua_conf_port_info();
            Helper.GuardError(PJSUA_DLL.Media.pjsua_conf_get_port_info(portId, ref info));
            return _mapper.Map(info);
        }

        public void Connect(int source, int sink)
        {
            Helper.GuardPositiveInt(source);
            Helper.GuardPositiveInt(sink);
            Helper.GuardError(PJSUA_DLL.Media.pjsua_conf_connect(source, sink));
        }

        public void Disconnect(int source, int sink)
        {
            Helper.GuardPositiveInt(source);
            Helper.GuardPositiveInt(sink); 
            Helper.GuardError(PJSUA_DLL.Media.pjsua_conf_disconnect(source, sink));
        }

        public void AdjustTxLevel(int slot, float level)
        {
            Helper.GuardPositiveInt(slot);
            Helper.GuardInRange(0.0f, 1.0f, level);
            Helper.GuardError(PJSUA_DLL.Media.pjsua_conf_adjust_tx_level(slot, level));
        }

        public void AdjustRxLevel(int slot, float level)
        {
            Helper.GuardPositiveInt(slot);
            Helper.GuardInRange(0.0f, 1.0f, level); 
            Helper.GuardError(PJSUA_DLL.Media.pjsua_conf_adjust_rx_level(slot, level));
        }

        public SignalLevel GetSignalLevel(int slot)
        {
            uint tx = 0, rx = 0;
            Helper.GuardError(PJSUA_DLL.Media.pjsua_conf_get_signal_level(slot, ref tx, ref rx));
            return new SignalLevel(rx, tx);
        }

        public int CreatePlayerAndGetId(string fileName, uint options)
        {
            var id = NativeConstants.PJSUA_INVALID_ID;
            var name = new pj_str_t(fileName);
            Helper.GuardError(PJSUA_DLL.Media.pjsua_player_create(ref name, options, ref id));
            return id;
        }

        public int CreatePlaylistAndGetId(string fileNames, uint fileCount, string label, uint options)
        {
            var id = NativeConstants.PJSUA_INVALID_ID;
            var name = new pj_str_t(fileNames);
            var lbl = new pj_str_t(label);
            Helper.GuardError(PJSUA_DLL.Media.pjsua_playlist_create(ref name, fileCount, ref lbl, options, ref id));
            return id;
        }

        public int GetPlayerConfPort(int playerId)
        {
            Helper.GuardPositiveInt(playerId);
            return PJSUA_DLL.Media.pjsua_player_get_conf_port(playerId);
        }

        public void SetPlayerPosition(int id, uint samples)
        {
            Helper.GuardPositiveInt(id);
            Helper.GuardError(PJSUA_DLL.Media.pjsua_player_set_pos(id, samples));
        }

        public void DestroyPlayer(int id)
        {
            Helper.GuardPositiveInt(id);
            Helper.GuardError(PJSUA_DLL.Media.pjsua_player_destroy(id));
        }

        public int CreateRecorderAndGetId(string filename, uint encType, IntPtr encParam, int maxSize, uint options)
        {
            var id = NativeConstants.PJSUA_INVALID_ID;
            var name = new pj_str_t(filename);
            Helper.GuardError(PJSUA_DLL.Media.pjsua_recorder_create(ref name, encType, encParam, maxSize, options,
                                                                    ref id));
            return id;
        }

        public int GetRecorderConfPort(int id)
        {
            Helper.GuardPositiveInt(id);
            return PJSUA_DLL.Media.pjsua_recorder_get_conf_port(id);
        }

        public void DestroyRecorder(int id)
        {
            Helper.GuardPositiveInt(id);
            Helper.GuardError(PJSUA_DLL.Media.pjsua_recorder_destroy(id));
        }

        public IEnumerable<SoundDeviceInfo> EnumerateSoundDevices()
        {
            var infos = new pjmedia_snd_dev_info[32];
            uint count = 32;
            Helper.GuardError(PJSUA_DLL.Media.pjsua_enum_snd_devs(infos, ref count));
            return infos.Select(i => _mapper.Map(i)).Aggregate(new List<SoundDeviceInfo>(), (l, s) =>
                                                                                                {
                                                                                                    s.Id = l.Count;
                                                                                                    l.Add(s);
                                                                                                    return l;
                                                                                                });
        }

        public Tuple<int, int> GetCurrentSoundDevices()
        {
            int capId = NativeConstants.PJSUA_INVALID_ID, plbckId = NativeConstants.PJSUA_INVALID_ID;
            Helper.GuardError(PJSUA_DLL.Media.pjsua_get_snd_dev(ref capId, ref plbckId));
            return new Tuple<int, int>(capId, plbckId);
        }

        public void SetCurrentSoundDevices(Tuple<int, int> deviceIds)
        {
            Helper.GuardPositiveInt(deviceIds.Part1);
            Helper.GuardPositiveInt(deviceIds.Part2);
            Helper.GuardError(PJSUA_DLL.Media.pjsua_set_snd_dev(deviceIds.Part1, deviceIds.Part2));
        }

        public void SetCurrentSoundDevicesToNull()
        {
            Helper.GuardError(PJSUA_DLL.Media.pjsua_set_null_snd_dev());
        }

        public void SetEc(uint tailMs, uint options)
        {
            Helper.GuardError(PJSUA_DLL.Media.pjsua_set_ec(tailMs, options));
        }

        public uint GetEcTail()
        {
            uint ecTail = 0;
            Helper.GuardError(PJSUA_DLL.Media.pjsua_get_ec_tail(ref ecTail));
            return ecTail;
        }

        public IEnumerable<CodecInfo> EnumerateCodecs()
        {
            var infos = new pjsua_codec_info[32];
            uint count = 32;
            Helper.GuardError(PJSUA_DLL.Media.pjsua_enum_codecs(infos, ref count));
            return infos.Select(i => _mapper.Map(i));
        }

        public void SetCodecPriority(string codecId, byte priority)
        {
            var codec = new pj_str_t(codecId);
            Helper.GuardError(PJSUA_DLL.Media.pjsua_codec_set_priority(ref codec, priority));
        }

        public void CreateMediaTransport(TransportConfig cfg)
        {
            var config = _mapper.Map(cfg, new pjsua_transport_config());
            Helper.GuardError(PJSUA_DLL.Media.pjsua_media_transports_create(config));
        }

        #endregion
    }
}