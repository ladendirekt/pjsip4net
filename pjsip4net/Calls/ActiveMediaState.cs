using System;
using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;
using System.Text;

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
                if (_context.Registry.Config.AutoRecord)
                {
                    _context.Record();
                }
            }
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            CallInfo info = null;
            bool disposed = false;
            try
            {
                info = _context.Call.GetCallInfo();
            }
            catch (ObjectDisposedException)
            {
                disposed = true;
            }

            if ((info != null && info.State == InviteState.Disconnected) || disposed)
            {
                _context.ChangeState(new DisconnectedMediaState(_context));
                return;
            }

            if (info.MediaStatus == CallMediaState.Error)
                _context.ChangeState(new ErrorMediaState(_context));
            else if (info.MediaStatus == CallMediaState.LocalHold || info.MediaStatus == CallMediaState.RemoteHold)
                _context.ChangeState(new HoldMediaState(info.MediaStatus, _context));
            else if (info.MediaStatus == CallMediaState.Active)
                _context.ChangeState(new ActiveMediaState(_context)); //to remove decorator
        }

        #endregion
    }
}