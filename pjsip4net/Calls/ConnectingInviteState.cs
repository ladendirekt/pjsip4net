using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Calls
{
    /// <summary>
    /// After 2xx is sent/received
    /// </summary>
    internal class ConnectingInviteState : AbstractState<InviteSession>
    {
        public ConnectingInviteState(InviteSession context)
            : base(context)
        {
            LogManager.GetLogger<ConnectingInviteState>()
                .DebugFormat("Call {0} {1}", _context.Call.Id, GetType().Name);
            _context.InviteState = InviteState.Connecting;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            CallInfo info = _context.Call.GetCallInfo();
            if (info.State == InviteState.Confirmed)
                _context.ChangeState(new ConfirmedInviteState(_context));
            else if (info.State == InviteState.Disconnected)
                _context.ChangeState(new DisconnectedInviteState(_context));
        }

        #endregion
    }
}