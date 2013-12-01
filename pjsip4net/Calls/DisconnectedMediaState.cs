using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Calls
{
    internal class DisconnectedMediaState : AbstractState<MediaSession>
    {
        public DisconnectedMediaState(MediaSession context)
            : base(context)
        {
            LogManager.GetLogger<DisconnectedMediaState>()
                .DebugFormat("Call {0} {1}", _context.Call.Id, GetType().Name);
            _context.IsActive = false;
            _context.IsHeld = false;
            _context.MediaState = CallMediaState.Disconnected;
            _context.CallManager.TerminateCall(_context.Call);
        }

        public override void StateChanged()
        {
        }
    }
}