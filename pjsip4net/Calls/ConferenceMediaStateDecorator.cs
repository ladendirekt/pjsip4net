using Common.Logging;
using pjsip4net.Core.Utils;

namespace pjsip4net.Calls
{
    internal class ConferenceMediaStateDecorator : AbstractState<MediaSession>
    {
        private readonly ActiveMediaState _inner;

        public ConferenceMediaStateDecorator(MediaSession context, ActiveMediaState inner)
            : base(context)
        {
            Helper.GuardNotNull(inner);
            _inner = inner;
            LogManager.GetLogger<ConferenceMediaStateDecorator>()
                .DebugFormat("Call {0} {1}", _context.Call.Id, GetType().Name);
            _context.ConferenceBridge.ConnectCall(_context.Call);
            _context.IsInConference = true;
        }

        #region Overrides of AbstractState

        public override void StateChanged()
        {
            if (_context.IsInConference)
            {
                _context.ConferenceBridge.DisconnectCall(_context.Call);
                _context.IsInConference = false;
            }
            _inner.StateChanged(); //let pj take care about disconnection
        }

        #endregion
    }
}