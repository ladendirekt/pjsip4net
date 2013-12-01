using System;
using pjsip4net.Core.Utils;

namespace pjsip4net.Accounts
{
    internal class RegistrationSession : StateMachine, IDisposable
    {
        private WeakReference _account;

        public RegistrationSession(Account owner)
        {
            Helper.GuardNotNull(owner);
            _account = new WeakReference(owner);
            _state = new InitializingAccountState(this);
        }

        public Account Account
        {
            get
            {
                if (_account.IsAlive)
                    return (Account)_account.Target;
                throw new ObjectDisposedException("account");
            }
        }

        public virtual bool IsRegistered { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            _account = null;
            _state = null;
        }

        #endregion
    }
}