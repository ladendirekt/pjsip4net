using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Calls
{
    internal class ActiveMediaState : AbstractState<MediaSession>
    {
        public ActiveMediaState(MediaSession context)
            : base(context)
        {
            _context.IsHeld = false;
            LogManager.GetLogger<ActiveMediaState>()
                .DebugFormat("Call {0} {1}", _context.Call.Id, GetType().Name);
            //connect call's media to sound device
            if (!_context.IsActive)
            {
                _context.ConferenceBridge.ConnectToSoundDevice(
                    _context.Call.ConferenceSlotId);
                _context.IsActive = true;
                _context.MediaState = CallMediaState.Active;
            }
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            var info = _context.Call.GetCallInfo();
            if (info.State == InviteState.Disconnected)
            {
                _context.ChangeState(new DisconnectedMediaState(_context));
                return;
            }

            if (info.MediaStatus == CallMediaState.Error)
                _context.ChangeState(new ErrorMediaState(_context));
            else if (info.MediaStatus == CallMediaState.LocalHold)
                _context.ChangeState(new LocalHoldMediaState(_context));
            else if (info.MediaStatus == CallMediaState.RemoteHold)
                _context.ChangeState(new RemoteHoldMediaState(_context));
            else if (info.MediaStatus == CallMediaState.Active)
                _context.ChangeState(new ActiveMediaState(_context)); //to remove decorator
        }

        #endregion
    }
}