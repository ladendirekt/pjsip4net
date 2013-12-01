using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Calls
{
    internal class RemoteHoldMediaState : AbstractState<MediaSession>
    {
        public RemoteHoldMediaState(MediaSession context)
            : base(context)
        {
            _context.IsHeld = true;
            LogManager.GetLogger<RemoteHoldMediaState>()
                .DebugFormat("Call {0} {1}", _context.Call.Id, GetType().Name);
            _context.MediaState = CallMediaState.RemoteHold;
            //connect media if not connected
            if (!_context.IsActive)
            {
                _context.IsActive = true;
                _context.ConferenceBridge.ConnectToSoundDevice(
                    _context.Call.ConferenceSlotId);
            }
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            var info = _context.Call.GetCallInfo();
            if (info.MediaStatus == CallMediaState.Active)
            {
                if (_context.Registry.Config.AutoConference)
                    _context.ChangeState(new ConferenceMediaStateDecorator(_context, new ActiveMediaState(_context)));
                else _context.ChangeState(new ActiveMediaState(_context));
            }
            else if (info.MediaStatus == CallMediaState.Error)
                _context.ChangeState(new ErrorMediaState(_context));
            else if (info.MediaStatus == CallMediaState.None)
                _context.ChangeState(new DisconnectedMediaState(_context));
        }

        #endregion
    }
}