using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Calls
{
    /// <summary>
    /// Before INVITE is sent or received
    /// </summary>
    internal class NullInviteState : AbstractState<InviteSession>
    {
        public NullInviteState(InviteSession context)
            : base(context)
        {
            LogManager.GetLogger<NullInviteState>()
                .DebugFormat("Call {0} {1}", _context.Call.Id, GetType().Name);
            _context.InviteState = InviteState.None;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            CallInfo info = _context.Call.GetCallInfo();
            if (info.State == InviteState.Disconnected)
                _context.ChangeState(new DisconnectedInviteState(_context));
            else
                _context.ChangeState(new CallingInviteState(_context)); //after INVITE is sent
        }

        #endregion
    }
}