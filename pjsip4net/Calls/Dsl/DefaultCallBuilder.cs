using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Calls.Dsl
{
    internal class DefaultCallBuilder : ICallBuilder
    {
        private readonly SipUriBuilder _sb = new SipUriBuilder();
        protected IAccount _account;
        private ICallManagerInternal _callManager;
        private IAccountManager _accountManager;

        public DefaultCallBuilder(ICallManagerInternal callManager, IAccountManager accountManager)
        {
            Helper.GuardNotNull(callManager);
            Helper.GuardNotNull(accountManager);
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

            return InternalCall();
        }

        protected ICall InternalCall()
        {
            return _callManager.MakeCall(_account, _sb.ToString());
        }
    }
}