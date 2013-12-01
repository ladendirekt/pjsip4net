using pjsip4net.Accounts;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls.Dsl
{
    internal class DefaultCallBuilder : ICallBuilder
    {
        private readonly SipUriBuilder _sb = new SipUriBuilder();
        protected IAccount _account;
        private readonly Call _call;
        private readonly ICallManagerInternal _callManager;
        private readonly IAccountManager _accountManager;

        public DefaultCallBuilder(Call call, ICallManagerInternal callManager, IAccountManager accountManager)
        {
            Helper.GuardNotNull(callManager);
            Helper.GuardNotNull(accountManager);
            Helper.GuardNotNull(call);
            _call = call;
            _callManager = callManager;
            _accountManager = accountManager;
        }

        public ICallBuilder To(string extension)
        {
            _sb.AppendExtension(extension);
            return this;
        }

        public ICallBuilder At(string domain)
        {
            _sb.AppendDomain(domain);
            return this;
        }

        public ICallBuilder Through(string port)
        {
            _sb.AppendPort(port);
            return this;
        }

        public ICallBuilder From(IAccount account)
        {
            _account = account;
            return this;
        }

        public ICall Call()
        {
            _account = _account ?? _accountManager.DefaultAccount;
            IVoIPTransport transport = _account.Transport;
            _sb.AppendTransportSuffix(transport.TransportType);
            _call.SetAccount(_account.As<Account>());

            using (Call().InitializationScope())
            {
                _call.SetDestinationUri(_sb.ToString());
            }
            
            InternalCall();
            return _call;
        }

        protected void InternalCall()
        {
            _callManager.RegisterCall(_call);
        }
    }
}