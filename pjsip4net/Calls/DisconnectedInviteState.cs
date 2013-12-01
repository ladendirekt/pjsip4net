using System.Diagnostics;
using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls
{
    /// <summary>
    /// Session is terminated
    /// </summary>
    internal class DisconnectedInviteState : AbstractState<InviteSession>
    {
        public DisconnectedInviteState(InviteSession context)
            : base(context)
        {
            LogManager.GetLogger<DisconnectedInviteState>()
                .DebugFormat("Call {0} {1}", _context.Call.Id, GetType().Name);
            _context.IsConfirmed = false;
            _context.IsDisconnected = true;
            _context.InviteState = InviteState.Disconnected;
            if (_context.IsRinging)
            {
                _context.CallManager.RaiseRingEvent(_context.Call, false);
                _context.IsRinging = false;
            }
            if (!_context.Call.HasMedia)
                _context.CallManager.TerminateCall(_context.Call);
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
        }

        #endregion
    }
}