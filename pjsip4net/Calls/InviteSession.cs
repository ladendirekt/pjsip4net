using System;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls
{
    internal class InviteSession : StateMachine, IDisposable
    {
        private readonly ICallManagerInternal _callManager;
        private WeakReference _call;

        public InviteSession(Call owner, ICallManagerInternal callManager)
        {
            _callManager = callManager;
            Helper.GuardNotNull(owner);
            Helper.GuardNotNull(callManager);
            _call = new WeakReference(owner);
            _state = owner.IsIncoming ? (AbstractState) new IncomingInviteState(this) : new NullInviteState(this);
        }

        public Call Call
        {
            get
            {
                if (_call.IsAlive)
                    return (Call) _call.Target;
                throw new ObjectDisposedException("call");
            }
        }

        public bool IsConfirmed { get; set; }
        public bool IsDisconnected { get; set; }
        public bool IsRinging { get; set; }
        public InviteState InviteState { get; set; }
        public ICallManagerInternal CallManager
        {
            get { return _callManager; }
        }

        #region IDisposable Members

        public void Dispose()
        {
            _call = null;
            _state = null;
        }

        #endregion
    }
}