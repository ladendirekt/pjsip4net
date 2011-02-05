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

        protected virtual ICall InternalCall()
        {
            return _callManager.MakeCall(_account, _sb.ToString());
        }
    }

    //public class ToCallBuilderExpression
    //{
    //    private readonly CallBuilder _builder;

    //    public ToCallBuilderExpression(CallBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public AtCallBuilderExpression To(string extension)
    //    {
    //        return new AtCallBuilderExpression(_builder.SetExtension(extension));
    //    }
    //}

    //public class AtCallBuilderExpression
    //{
    //    private readonly CallBuilder _builder;

    //    public AtCallBuilderExpression(CallBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public ThroughCallBuilderExpression At(string domain)
    //    {
    //        return new ThroughCallBuilderExpression(_builder.SetDomain(domain));
    //    }
    //}

    //public class ThroughCallBuilderExpression
    //{
    //    private readonly CallBuilder _builder;

    //    public ThroughCallBuilderExpression(CallBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public FromCallBuilderExpression Through(string port)
    //    {
    //        return new FromCallBuilderExpression(_builder.SetPort(port));
    //    }
    //}

    //public class FromCallBuilderExpression
    //{
    //    private readonly CallBuilder _builder;

    //    public FromCallBuilderExpression(CallBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public GoCallBuilderExpression From(Account account)
    //    {
    //        return new GoCallBuilderExpression(_builder.SetAccount(account));
    //    }
    //}

    //public class GoCallBuilderExpression
    //{
    //    private readonly CallBuilder _builder;

    //    public GoCallBuilderExpression(CallBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public Call Go()
    //    {
    //        return _builder.Call();
    //    }
    //}
}