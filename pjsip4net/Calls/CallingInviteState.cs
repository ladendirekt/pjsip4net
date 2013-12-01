using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Calls
{
    /// <summary>
    /// After INVITE is sent
    /// </summary>
    internal class CallingInviteState : AbstractState<InviteSession>
    {
        public CallingInviteState(InviteSession context)
            : base(context)
        {
            LogManager.GetLogger<CallingInviteState>()
                .DebugFormat("Call {0} {1}", _context.Call.Id, GetType().Name);
            if (!_context.Call.IsIncoming)
                _context.CallManager.RaiseRingEvent(_context.Call, true);
            _context.IsRinging = true;
            _context.InviteState = InviteState.Calling;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            CallInfo info = _context.Call.GetCallInfo();
            if (info.State == InviteState.Confirmed)
                _context.ChangeState(new ConfirmedInviteState(_context));
            else if (info.State == InviteState.Connecting)
                _context.ChangeState(new ConnectingInviteState(_context));
            else if (info.State == InviteState.Disconnected)
                _context.ChangeState(new DisconnectedInviteState(_context));
        }

        #endregion
    }
}