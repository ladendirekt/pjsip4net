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
        private string _recordFileName;
        private bool _recordCall;

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

        public ICallBuilder RecordTo(string fileName)
        {
            _recordCall = true;
            _recordFileName = fileName;
            return this;
        }

        public ICall Call()
        {
            FinalizeUri();
            InitializeCall();
            RegisterCall();
            StartRecording();
            return _call;
        }

        private void InitializeCall()
        {
            using (_call.InitializationScope())
                _call.SetDestinationUri(_sb.ToString());
        }

        private void FinalizeUri()
        {
            _account = _account ?? _accountManager.DefaultAccount;
            IVoIPTransport transport = _account.Transport;
            _sb.AppendTransportSuffix(transport.TransportType);
            _call.SetAccount(_account.As<Account>());
        }

        protected void RegisterCall()
        {
            _callManager.RegisterCall(_call);
        }

        private void StartRecording()
        {
            if (_recordCall && ValidFileNameTemplate.Check(_recordFileName))
                _call.MediaSession.RecordTo(_recordFileName);
        }
    }
}