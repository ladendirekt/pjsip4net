using System;
using System.Collections.Generic;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Core.Interfaces.ApiProviders
{
    /// <summary>
    /// An abstraction of service enabling access to pjsua media API <seealso cref="http://www.pjsip.org/pjsip/docs/html/group__PJSUA__LIB__MEDIA.htm"/>
    /// </summary>
    public interface IMediaApiProvider
    {
        MediaConfig GetDefaultConfig();
        uint GetMaxConferencePorts();
        uint GetActivePortsCount();
        //int pjsua_enum_conf_ports(int[] id, ref uint count);
        ConferencePortInfo GetPortInfo(int portId);
        void Connect(int source, int sink);
        void Disconnect(int source, int sink);
        void AdjustTxLevel(int slot, float level);
        void AdjustRxLevel(int slot, float level);
        SignalLevel GetSignalLevel(int slot);

        int CreatePlayerAndGetId(string fileName, uint options);
        int CreatePlaylistAndGetId(string fileNames, uint fileCount, string label, uint options);
        int GetPlayerConfPort(int playerId);
        //int pjsua_player_get_port(int id, ref IntPtr p_port);
        void SetPlayerPosition(int id, uint samples);
        void DestroyPlayer(int id);

        int CreateRecorderAndGetId(string filename, uint encType, IntPtr encParam,
                                  int maxSize, uint options);
        int GetRecorderConfPort(int id);
        //int pjsua_recorder_get_port(int id, ref IntPtr p_port);
        void DestroyRecorder(int id);
        IEnumerable<SoundDeviceInfo> EnumerateSoundDevices();
        Tuple<int, int> GetCurrentSoundDevices();
        void SetCurrentSoundDevices(Tuple<int, int> deviceIds);
        void SetCurrentSoundDevicesToNull();
        //IntPtr pjsua_set_no_snd_dev();
        void SetEc(uint tailMs, uint options);
        uint GetEcTail();
        IEnumerable<CodecInfo> EnumerateCodecs();
        void SetCodecPriority(string codecId, byte priority);
        //int pjsua_codec_get_param(ref pj_str_t codec_id, ref pjmedia_codec_param param);
        //int pjsua_codec_set_param(ref pj_str_t codec_id, ref pjmedia_codec_param param);
        void CreateMediaTransport(TransportConfig cfg);
    }
}