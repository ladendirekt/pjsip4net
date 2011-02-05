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
        protected IVoIPTransport _transport;
        private readonly IObjectFactory _objectFactory;
        private readonly IAccountManagerInternal _accountManager;
        private readonly ILocalRegistry _localRegistry;

        public DefaultAccountBuilder(IObjectFactory objectFactory, IAccountManagerInternal accountManager, ILocalRegistry localRegistry)
        {
            Helper.GuardNotNull(objectFactory);
            Helper.GuardNotNull(accountManager);
            Helper.GuardNotNull(localRegistry);
            _objectFactory = objectFactory;
            _accountManager = accountManager;
            _localRegistry = localRegistry;
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

        public IAccountBuilder Via(IVoIPTransport transport)
        {
            _transport = transport;
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

        public IAccount Register()
        {
            if (string.IsNullOrEmpty(_registrarDomain))
                throw new ArgumentNullException("domain");

            IAccountInternal account = CreateAccount();
            using (account.InitializationScope())
            {
                account.Credential = new NetworkCredential(_login, _password, "*");

                var sb = new SipUriBuilder();
                sb.AppendExtension(_login).AppendDomain(_registrarDomain);
                if (!string.IsNullOrEmpty(_port))
                    sb.AppendPort(_port);
                _transport = _transport ?? _localRegistry.SipTransport;
                if (_transport is TcpTransport)
                    sb.AppendTransportSuffix(TransportType.Tcp);
                else if (_transport is TlsTransport)
                    sb.AppendTransportSuffix(TransportType.Tls);
                account.AccountId = sb.ToString();

                sb.Clear();

                sb.AppendDomain(_registrarDomain);
                if (!string.IsNullOrEmpty(_port))
                    sb.AppendPort(_port);
                if (_transport is TcpTransport)
                    sb.AppendTransportSuffix(TransportType.Tcp);
                else if (_transport is TlsTransport)
                    sb.AppendTransportSuffix(TransportType.Tls);

                account.RegistrarUri = sb.ToString();
                account.SetTransport(_transport);
                account.PublishPresence = _publish;
                if (_regTimeout != default(int))
                    account.RegistrationTimeout = _regTimeout;
            }

            InternalRegister(account);
            return account;
        }

        internal virtual IAccountInternal CreateAccount()
        {
            var account = _objectFactory.Create<IAccountInternal>();
            account.IsLocal = false;
            return account;
        }

        internal virtual void InternalRegister(IAccountInternal account)
        {
            _accountManager.RegisterAccount(account, _default);
        }
    }

    //public class WithAccountBuilderExpression
    //{
    //    private readonly AccountBuilder _builder;

    //    internal WithAccountBuilderExpression(AccountBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public AtAccountBuilderExpression With(string login, string password)
    //    {
    //        return
    //            new AtAccountBuilderExpression(_builder.SetLogin(login).SetPassword(password));
    //    }

    //    public AtAccountBuilderExpression With(string login, string password, uint registrationTimeout)
    //    {
    //        return
    //            new AtAccountBuilderExpression(
    //                _builder.SetLogin(login).SetPassword(password).SetRegistrationTimeout(registrationTimeout));
    //    }
    //}

    //public class AtAccountBuilderExpression
    //{
    //    private readonly AccountBuilder _builder;

    //    internal AtAccountBuilderExpression(AccountBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public ThroughAccountBuilderExpression At(string domain)
    //    {
    //        return new ThroughAccountBuilderExpression(_builder.SetDomain(domain));
    //    }
    //}

    //public class ThroughAccountBuilderExpression
    //{
    //    private readonly AccountBuilder _builder;

    //    internal ThroughAccountBuilderExpression(AccountBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public OverAccountBuilderExpression Through(string port)
    //    {
    //        return new OverAccountBuilderExpression(_builder.SetPort(port));
    //    }
    //}

    //public class OverAccountBuilderExpression
    //{
    //    private readonly AccountBuilder _builder;

    //    internal OverAccountBuilderExpression(AccountBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public GoAccountBuilderExpression Over(VoIPTransport transport)
    //    {
    //        return new GoAccountBuilderExpression(_builder.SetTransport(transport));
    //    }
    //}

    //public class GoAccountBuilderExpression
    //{
    //    private readonly AccountBuilder _builder;

    //    internal GoAccountBuilderExpression(AccountBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public Account Go(bool isDefault, bool publishPresence)
    //    {
    //        return _builder.SetDefault(isDefault).SetPublish(publishPresence).Register();
    //    }
    //}
}