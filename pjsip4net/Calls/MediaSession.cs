using System;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls
{
    internal class MediaSession : StateMachine, IDisposable
    {
        private WeakReference _call;
        private readonly ILocalRegistry _localRegistry;
        private readonly ICallManagerInternal _callManager;
        private readonly IConferenceBridge _conferenceBridge;

        public MediaSession(ICallInternal call, ILocalRegistry localRegistry,
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

        public ICallInternal Call
        {
            get
            {
                if (_call.IsAlive)
                    return (ICallInternal)_call.Target;
                throw new ObjectDisposedException("call");
            }
        }

        public bool IsHeld { get; set; }
        public bool IsActive { get; set; }
        public bool IsInConference { get; set; }
        public CallMediaState MediaState { get; set; }
        public ILocalRegistry Registry
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

        #region IDisposable Members

        public void Dispose()
        {
            _call = null;
            _state = null;
        }

        #endregion

        public void ConnectToConference()
        {
            if (!IsActive)
                return;
            if (IsInConference)
                return;

            _state = new ConferenceMediaStateDecorator(this, _state as ActiveMediaState);
        }

        public void DisconnectFromConference()
        {
            if (!IsActive)
                return;
            if (!IsInConference)
                return;

            _state.StateChanged();
        }
    }
}