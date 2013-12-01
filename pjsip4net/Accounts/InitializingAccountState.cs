using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Accounts
{
    /// <summary>
    /// Initial state
    /// </summary>
    internal class InitializingAccountState : AbstractState<RegistrationSession>
    {
        public InitializingAccountState(RegistrationSession context)
            : base(context)
        {
            LogManager.GetLogger<InitializingAccountState>()
                .DebugFormat("Account {0} InitializingAccountState", _context.Account.Id);
            _context.IsRegistered = false;
        }

        #region Overrides of AccountState

        public override void StateChanged()
        {
            AccountInfo info = _context.Account.GetAccountInfo();
            if (_context.Account.IsLocal)
                _context.ChangeState(new RegisteredAccountState(_context));
            else if (info.Status == SipStatusCode.Trying)
                _context.ChangeState(new RegisteringAccountState(_context));
            else
                _context.ChangeState(new UnknownStatusState(_context, info.Status, info.StatusText));
        }

        #endregion
    }
}