using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Calls
{
    internal class NoneMediaState : AbstractState<MediaSession>
    {
        public NoneMediaState(MediaSession context)
            : base(context)
        {
            LogManager.GetLogger<NoneMediaState>()
                .DebugFormat("Call {0} {1}", _context.Call.Id, GetType().Name);
            _context.IsActive = false;
            _context.IsHeld = false;
            _context.MediaState = CallMediaState.None;
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
        }

        #endregion
    }
}