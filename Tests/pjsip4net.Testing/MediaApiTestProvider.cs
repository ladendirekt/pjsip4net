using System;
using System.Collections.Generic;
using System.Timers;
using pjsip4net.Core.Data;
using pjsip4net.Core.Data.Events;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;

namespace pjsip4net.Testing
{
    public class MediaApiTestProvider : IMediaApiProvider
    {
        private readonly IEventsProvider _eventsProvider;

        public MediaApiTestProvider(IEventsProvider eventsProvider)
        {
            _eventsProvider = eventsProvider;
        }

        public MediaConfig GetDefaultConfig()
        {
            return new MediaConfig();
        }

        public uint GetMaxConferencePorts()
        {
            return 1;
        }

        public uint GetActivePortsCount()
        {
            return 0;
        }

        public ConferencePortInfo GetPortInfo(int portId)
        {
            return new ConferencePortInfo();
        }

        public void Connect(int source, int sink)
        {
        }

        public void Disconnect(int source, int sink)
        {
        }

        public void AdjustTxLevel(int slot, float level)
        {
        }

        public void AdjustRxLevel(int slot, float level)
        {
        }

        public SignalLevel GetSignalLevel(int slot)
        {
            return new SignalLevel();
        }

        public int CreatePlayerAndGetId(string fileName, uint options)
        {
            if (options == 1)
            {
                var timer = new Timer(10);
                timer.Elapsed += (sender, args) =>
                {
                    _eventsProvider.Publish(new PlayerCompleted() {Id = 0});
                    timer.Dispose();
                };
                timer.Enabled = true;
            }
            return 0;
        }

        public int CreatePlaylistAndGetId(string fileNames, uint fileCount, string label, uint options)
        {
            return 0;
        }

        public int GetPlayerConfPort(int playerId)
        {
            return 0;
        }

        public void SetPlayerPosition(int id, uint samples)
        {
        }

        public void DestroyPlayer(int id)
        {
        }

        public int CreateRecorderAndGetId(string filename, uint encType, IntPtr encParam, int maxSize, uint options)
        {
            return 0;
        }

        public int GetRecorderConfPort(int id)
        {
            return 0;
        }

        public void DestroyRecorder(int id)
        {
        }

        public IEnumerable<SoundDeviceInfo> EnumerateSoundDevices()
        {
            yield break;
        }

        public Core.Utils.Tuple<int, int> GetCurrentSoundDevices()
        {
            return new Core.Utils.Tuple<int, int>();
        }

        public void SetCurrentSoundDevices(Core.Utils.Tuple<int, int> deviceIds)
        {
        }

        public void SetCurrentSoundDevicesToNull()
        {
        }

        public void SetEc(uint tailMs, uint options)
        {
        }

        public uint GetEcTail()
        {
            return 0;
        }

        public IEnumerable<CodecInfo> EnumerateCodecs()
        {
            yield break;
        }

        public void SetCodecPriority(string codecId, byte priority)
        {
        }

        public void CreateMediaTransport(TransportConfig cfg)
        {
        }
    }
}