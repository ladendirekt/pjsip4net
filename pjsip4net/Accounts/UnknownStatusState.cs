using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Accounts
{
    /// <summary>
    /// After unknown status recieved
    /// </summary>
    internal class UnknownStatusState : AbstractState<RegistrationSession>
    {
        public UnknownStatusState(RegistrationSession context, SipStatusCode code, string statusText)
            : base(context)
        {
            _context.IsRegistered = false;
            StatusCode = code;
            StatusText = statusText;
            var logger = LogManager.GetLogger<TimedOutAccountRegistrationState>();
            logger.DebugFormat("Account {0} UnknownStatusState", _context.Account.Id);
            logger.Debug(StatusText);
        }

        public SipStatusCode StatusCode { get; private set; }
        public string StatusText { get; private set; }

        public override void StateChanged()
        {
            AccountInfo info = _context.Account.GetAccountInfo();
            if (info.Status == SipStatusCode.Ok)
                _context.ChangeState(new RegisteredAccountState(_context));
            else if (info.Status == SipStatusCode.RequestTimeout)
                _context.ChangeState(new TimedOutAccountRegistrationState(_context));
            else if (info.Status == SipStatusCode.Trying)
                _context.ChangeState(new RegisteringAccountState(_context));
            else
                _context.ChangeState(new UnknownStatusState(_context, info.Status, info.StatusText));
        }
    }
}