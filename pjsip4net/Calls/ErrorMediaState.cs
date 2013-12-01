using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Calls
{
    internal class ErrorMediaState : AbstractState<MediaSession>
    {
        public ErrorMediaState(MediaSession context)
            : base(context)
        {
            _context.IsHeld = false;
            LogManager.GetLogger<ErrorMediaState>()
                .DebugFormat("Call {0} {1}", _context.Call.Id, GetType().Name);
            _context.MediaState = CallMediaState.Error;
            //disconnect call's media from sound device if connected
            if (_context.IsActive)
            {
                _context.IsActive = false;
                _context.ConferenceBridge.DisconnectFromSoundDevice(
                    _context.Call.ConferenceSlotId);
            }
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
        }

        #endregion
    }
}