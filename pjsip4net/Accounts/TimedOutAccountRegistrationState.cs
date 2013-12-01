using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Accounts
{
    /// <summary>
    /// After PjsipScRequestTimeout = 408 recieved 
    /// </summary>
    internal class TimedOutAccountRegistrationState : AbstractState<RegistrationSession>
    {
        public TimedOutAccountRegistrationState(RegistrationSession context)
            : base(context)
        {
            LogManager.GetLogger<TimedOutAccountRegistrationState>()
                .DebugFormat("Account {0} TimedOutAccountRegistrationState", _context.Account.Id);
            _context.IsRegistered = false;
            //_owner.Account.Dispose();//account can be re-registered - no need to dispose and delete
        }

        #region Overrides of AccountState

        public override void StateChanged()
        {
            AccountInfo info = _context.Account.GetAccountInfo();
            if (info.Status == SipStatusCode.Ok)
                _context.ChangeState(new RegisteredAccountState(_context));
            else if (info.Status == SipStatusCode.Trying)
                _context.ChangeState(new RegisteringAccountState(_context));
            else
                _context.ChangeState(new UnknownStatusState(_context, info.Status, info.StatusText));
        }

        #endregion
    }
}