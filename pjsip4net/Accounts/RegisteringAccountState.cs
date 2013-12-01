using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Accounts
{
    /// <summary>
    /// After remote registration session started
    /// </summary>
    internal class RegisteringAccountState : AbstractState<RegistrationSession>
    {
        public RegisteringAccountState(RegistrationSession context)
            : base(context)
        {
            LogManager.GetLogger<RegisteringAccountState>()
                .DebugFormat("Account {0} RegisteringAccountState", _context.Account.Id);
            _context.IsRegistered = false;
        }

        #region Overrides of AccountState

        public override void StateChanged()
        {
            AccountInfo info = _context.Account.GetAccountInfo();
            if (info.Status == SipStatusCode.RequestTimeout)
                _context.ChangeState(new TimedOutAccountRegistrationState(_context));
            else if (info.Status == SipStatusCode.Ok)
                _context.ChangeState(new RegisteredAccountState(_context));
            else
                _context.ChangeState(new UnknownStatusState(_context, info.Status, info.StatusText));
        }

        #endregion
    }
}