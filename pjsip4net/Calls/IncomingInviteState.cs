using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Calls
{
    /// <summary>
    /// After INVITE is received
    /// </summary>
    internal class IncomingInviteState : AbstractState<InviteSession>
    {
        public IncomingInviteState(InviteSession context)
            : base(context)
        {
            LogManager.GetLogger<IncomingInviteState>()
                .DebugFormat("Call {0} {1}", _context.Call.Id, GetType().Name);
            //SingletonHolder<ICallManagerImpl>.Instance.RaiseRingEvent(_owner.Call, true);
            _context.IsRinging = true;
            _context.InviteState = InviteState.Incoming;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            CallInfo info = _context.Call.GetCallInfo();
            if (info.State == InviteState.Confirmed)
                _context.ChangeState(new ConfirmedInviteState(_context));
            else if (info.State == InviteState.Connecting)
                _context.ChangeState(new ConnectingInviteState(_context));
            else if (info.State == InviteState.Early)
                _context.ChangeState(new EarlyInviteState(_context));
            else if (info.State == InviteState.Disconnected)
                _context.ChangeState(new DisconnectedInviteState(_context));
        }

        #endregion
    }
}