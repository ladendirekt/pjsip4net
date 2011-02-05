using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using pjsip4net.Calls;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Media
{
    internal class DefaultConferenceBridge : IConferenceBridge
    {
        #region Private Data

        private readonly List<ICall> _calls = new List<ICall>();
        private readonly object _lock = new object();
        private readonly IMediaApiProvider _mediaApi;

        #endregion

        #region Properties

        public bool IsConferenceActive
        {
            get { return _calls.Count > 1; }
        }

        public uint MaxPorts
        {
            get { return _mediaApi.GetMaxConferencePorts(); }
        }

        public uint ActivePorts
        {
            get { return _mediaApi.GetActivePortsCount(); }
        }

        public double? RxLevel
        {
            get { return _calls.Count > 0 ? _calls.Select(c => c.RxLevel).Average() : (double?) null; }
            set
            {
                foreach (Call call in _calls)
                    call.RxLevel = value.Value;
            }
        }

        public double? TxLevel
        {
            get { return _calls.Count > 0 ? _calls.Select(c => c.TxLevel).Average() : (double?) null; }
            set
            {
                foreach (Call call in _calls)
                    call.TxLevel = value.Value;
            }
        }

        #endregion

        #region Methods

        public DefaultConferenceBridge(IMediaApiProvider mediaApi)
        {
            _mediaApi = mediaApi;
        }

        public void Interconnect(int slotX, int slotY)
        {
            Helper.GuardPositiveInt(slotX);
            Helper.GuardPositiveInt(slotY);
            _mediaApi.Connect(slotX, slotY);
            _mediaApi.Connect(slotY, slotX);
        }

        public void Disconnect(int slotX, int slotY)
        {
            Helper.GuardPositiveInt(slotX);
            Helper.GuardPositiveInt(slotY);
            _mediaApi.Disconnect(slotX, slotY);
            _mediaApi.Disconnect(slotY, slotX);
        }

        public void ConnectToSoundDevice(int slotId)
        {
            Interconnect(slotId, 0);
        }

        public void DisconnectFromSoundDevice(int slotId)
        {
            Disconnect(slotId, 0);
        }

        public void ConnectCall(ICall call)
        {
            Helper.GuardNotNull(call);
            Helper.GuardPositiveInt(call.Id);
            //Helper.GuardNotNull(call.ConferenceSlotInfo);

            //lock (_lock)
            {
                foreach (ICall c in _calls)
                    Interconnect(call.ConferenceSlotId, c.ConferenceSlotId);
                _calls.Add(call);

                Debug.WriteLine("Conference connected call id = " + call.Id);
            }
        }

        public void DisconnectCall(ICall call)
        {
            Helper.GuardNotNull(call);
            Helper.GuardPositiveInt(call.Id);

            //lock (_lock)
            {
                _calls.Remove(call);

                //if (call.IsActive && call.HasMedia)
                //foreach (var c in _calls)
                //    Disconnect(call.ConferenceSlotId, c.ConferenceSlotId);

                Debug.WriteLine("Conference disconnected call id = " + call.Id);
            }
        }

        #endregion
    }
}