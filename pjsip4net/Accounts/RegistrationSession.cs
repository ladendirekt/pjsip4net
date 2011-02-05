using System;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Accounts
{
    internal class RegistrationSession : StateMachine, IDisposable
    {
        private WeakReference _account;

        public RegistrationSession(IAccountInternal owner)
        {
            Helper.GuardNotNull(owner);
            _account = new WeakReference(owner);
            _state = new InitializingAccountState(this);
        }

        public IAccountInternal Account
        {
            get
            {
                if (_account.IsAlive)
                    return (IAccountInternal)_account.Target;
                throw new ObjectDisposedException("account");
            }
        }

        public bool IsRegistered { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            _account = null;
            _state = null;
        }

        #endregion
    }
}