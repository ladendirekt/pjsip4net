using Common.Logging;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Accounts
{
    /// <summary>
    /// Either after PjsipScOk = 200 recieved or local account been added
    /// </summary>
    internal class RegisteredAccountState : AbstractState<RegistrationSession>
    {
        public RegisteredAccountState(RegistrationSession context)
            : base(context)
        {
            LogManager.GetLogger<RegisteredAccountState>()
                .DebugFormat("Account {0} RegisteredAccountState", _context.Account.Id);
            _context.IsRegistered = true;
            //if (_owner.Account.PublishPresence)
            //    _owner.Account.IsOnline = true;
        }

        #region Overrides of AccountState

        public override void StateChanged()
        {
            if (_context.Account.Id == -1 && _context.Account.IsLocal)
                _context.ChangeState(new InitializingAccountState(_context));
            else
            {
                AccountInfo info = _context.Account.GetAccountInfo();
                if (info.Status == (SipStatusCode) 1 || info.Status == SipStatusCode.Ok) //OK
                    return;
                //_owner.Account.IsOnline = false;
                if (info.Status == SipStatusCode.RequestTimeout)
                    _context.ChangeState(new TimedOutAccountRegistrationState(_context));
                else if (info.Status == SipStatusCode.Trying)
                    _context.ChangeState(new RegisteringAccountState(_context));
                else
                    _context.ChangeState(new UnknownStatusState(_context, info.Status, info.StatusText));
            }
        }

        #endregion
    }
}