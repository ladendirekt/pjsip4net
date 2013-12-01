using System;
using System.Net;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;
using pjsip4net.Transport;
using TransportType=pjsip4net.Core.TransportType;

namespace pjsip4net.Accounts.Dsl
{
    internal class DefaultAccountBuilder : IAccountBuilder
    {
        protected bool _default;
        protected string _login;
        protected string _password;
        protected string _port;
        protected bool _publish;
        protected string _registrarDomain;
        protected uint _regTimeout;
        protected VoIPTransport _transport;
        private readonly IAccountManagerInternal _accountManager;
        private Account _account;
        private IDisposable _accountScope;

        public DefaultAccountBuilder(Account account, VoIPTransport transport, IAccountManagerInternal accountManager)
        {
            Helper.GuardNotNull(account);
            Helper.GuardNotNull(transport);
            Helper.GuardNotNull(accountManager);
            _accountManager = accountManager;
            _account = account;
            _account.IsLocal = false;
            _transport = transport;
            _accountScope = _account.InitializationScope();
        }

        public IAccountBuilder WithExtension(string login)
        {
            _login = login;
            return this;
        }

        public IAccountBuilder WithPassword(string password)
        {
            _password = password;
            return this;
        }

        public IAccountBuilder At(string domain)
        {
            _registrarDomain = domain;
            return this;
        }

        public IAccountBuilder Through(string port)
        {
            _port = port;
            return this;
        }

        public IAccountBuilder Default()
        {
            _default = true;
            return this;
        }

        public IAccountBuilder PublishingPresence()
        {
            _publish = true;
            return this;
        }

        public IAccountBuilder WithRegistrationTimeout(uint registrationTimeout)
        {
            _regTimeout = registrationTimeout;
            return this;
        }

        public IAccountBuilder ExposeAccount(Action<IAccount> editAccount)
        {
            if (editAccount != null)
                editAccount(_account);
            return this;
        }

        public IAccount Register()
        {
            if (string.IsNullOrEmpty(_registrarDomain))
                throw new ArgumentNullException("domain");

            using (_accountScope)
            {
                _account.Credential = new NetworkCredential(_login, _password, "*");

                var sb = new SipUriBuilder();
                sb.AppendExtension(_login).AppendDomain(_registrarDomain);
                if (!string.IsNullOrEmpty(_port))
                    sb.AppendPort(_port);
                if (_transport is TcpTransport)
                    sb.AppendTransportSuffix(TransportType.Tcp);
                else if (_transport is TlsTransport)
                    sb.AppendTransportSuffix(TransportType.Tls);
                _account.AccountId = sb.ToString();

                sb.Clear();

                sb.AppendDomain(_registrarDomain);
                if (!string.IsNullOrEmpty(_port))
                    sb.AppendPort(_port);
                if (_transport is TcpTransport)
                    sb.AppendTransportSuffix(TransportType.Tcp);
                else if (_transport is TlsTransport)
                    sb.AppendTransportSuffix(TransportType.Tls);

                _account.RegistrarUri = sb.ToString();
                _account.SetTransport(_transport);
                _account.PublishPresence = _publish;
                if (_regTimeout != default(int))
                    _account.RegistrationTimeout = _regTimeout;
            }

            InternalRegister(_account);
            return _account;
        }

        internal virtual void InternalRegister(Account account)
        {
            _accountManager.RegisterAccount(account, _default);
        }
    }
}