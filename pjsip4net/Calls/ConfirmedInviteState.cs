using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Calls
{
    /// <summary>
    /// After ACK is sent/received
    /// </summary>
    internal class ConfirmedInviteState : AbstractState<InviteSession>
    {
        public ConfirmedInviteState(InviteSession context)
            : base(context)
        {
            LogManager.GetLogger<ConfirmedInviteState>()
                .DebugFormat("Call {0} {1}", _context.Call.Id, GetType().Name);
            if (_context.IsRinging)
            {
                _context.CallManager.RaiseRingEvent(_context.Call, false);
                _context.IsRinging = false;
            }
            _context.IsConfirmed = true;
            _context.InviteState = InviteState.Confirmed;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            CallInfo info = _context.Call.GetCallInfo();
            if (info.State == InviteState.Disconnected)
                _context.ChangeState(new DisconnectedInviteState(_context));
        }

        #endregion
    }
}