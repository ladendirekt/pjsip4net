using System;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls
{
    internal class MediaSession : StateMachine, IDisposable
    {
        private WeakReference _call;
        private readonly IRegistry _localRegistry;
        private readonly ICallManagerInternal _callManager;
        private readonly IConferenceBridge _conferenceBridge;
        private IWavRecorder _callRecorder;
        private string _recordFileName;

        public MediaSession(Call call, IRegistry localRegistry,
            ICallManagerInternal callManager, IConferenceBridge conferenceBridge)
        {
            Helper.GuardNotNull(call);
            Helper.GuardNotNull(localRegistry);
            Helper.GuardNotNull(callManager);
            Helper.GuardNotNull(conferenceBridge);
            _call = new WeakReference(call);
            _state = new NoneMediaState(this);
            _localRegistry = localRegistry;
            _callManager = callManager;
            _conferenceBridge = conferenceBridge;
        }

        public Call Call
        {
            get
            {
                if (_call.IsAlive)
                    return (Call)_call.Target;
                throw new ObjectDisposedException("call");
            }
        }

        public bool IsHeld { get; set; }
        public bool IsActive { get; set; }
        public bool IsInConference { get; set; }
        public bool RecordToFile
        { 
            get { return _recordFileName != null; } 
        }
        public CallMediaState MediaState { get; set; }
        public IRegistry Registry
        {
            get { return _localRegistry; }
        }
        public ICallManagerInternal CallManager
        {
            get { return _callManager; }
        }
        public IConferenceBridge ConferenceBridge
        {
            get { return _conferenceBridge; }
        }

        public void RecordTo(string fileName)
        {
            _recordFileName = fileName;
            StartRecording();
        }

        public void ConnectToConference()
        {
            if (!IsActive)
                return;
            if (IsInConference)
                return;

            _state = new ConferenceMediaStateDecorator(this, _state.As<ActiveMediaState>());
        }

        public void DisconnectFromConference()
        {
            if (!IsActive)
                return;
            if (!IsInConference)
                return;

            _state.StateChanged();
        }

        protected override void OnStateChanged()
        {
            base.OnStateChanged();
            if (RecordToFile)
                StartRecording();
        }

        public void Dispose()
        {
            if (_callRecorder != null)
                _callRecorder.Dispose();
        }

        private void StartRecording()
        {
            if (!IsActive)
                return;
            if (_callRecorder == null)
            {
                _callRecorder = Registry.Container.Get<IWavRecorder>();
                _callRecorder.Start(_recordFileName);
                ConferenceBridge.Connect(Call.ConferenceSlotId, _callRecorder.ConferenceSlot.SlotId);
            }
        }
    }
}