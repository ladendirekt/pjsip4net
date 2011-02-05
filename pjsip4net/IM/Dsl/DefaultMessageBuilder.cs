using pjsip4net.Core;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.IM.Dsl
{
    internal class DefaultMessageBuilder : IMessageBuilder
    {
        private readonly SipUriBuilder _builder = new SipUriBuilder();
        private string _body;
        private IAccount _from;
        private ICall _dialog;
        private IImManager _manager;

        public DefaultMessageBuilder(IImManager manager)
        {
            Helper.GuardNotNull(manager);
            _manager = manager;
        }

        public IMessageBuilder To(string extension)
        {
            _builder.AppendExtension(extension);
            return this;
        }

        public IMessageBuilder At(string domain)
        {
            _builder.AppendDomain(domain);
            return this;
        }

        public IMessageBuilder Through(string port)
        {
            _builder.AppendPort(port);
            return this;
        }

        public IMessageBuilder WithBody(string body)
        {
            _body = body;
            return this;
        }

        public IMessageBuilder From(IAccount account)
        {
            Helper.GuardNotNull(account);
            Helper.GuardNotNull(account.Transport);
            TransportType ttype = account.Transport.TransportType;
            _builder.AppendTransportSuffix(ttype);
            _from = account;
            return this;
        }

        public IMessageBuilder InDialogOf(ICall call)
        {
            Helper.GuardNotNull(call);
            _dialog = call;
            return this;
        }

        public void Send()
        {
            if (_dialog == null)
                _manager.SendMessage(_from, _body, _builder.ToString());
            else
                _manager.SendMessageInDialog(_dialog, _body);
        }

        public void SendTyping()
        {
            if (_dialog == null)
                _manager.SendTyping(_from, _builder.ToString(), true);
            else
                _manager.SendTypingInDialog(_dialog, true);
        }
        
        public void SendFinishedTyping()
        {
            if (_dialog == null)
                _manager.SendTyping(_from, _builder.ToString(), false);
            else
                _manager.SendTypingInDialog(_dialog, false);
        }
    }

    //public class ToMessageBuilderExpression
    //{
    //    private readonly MessageBuilder _builder;

    //    public ToMessageBuilderExpression(MessageBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public AtMessageBuilderExpression To(string extension)
    //    {
    //        return new AtMessageBuilderExpression(_builder.SetExtension(extension));
    //    }
    //}

    //public class AtMessageBuilderExpression
    //{
    //    private readonly MessageBuilder _builder;

    //    public AtMessageBuilderExpression(MessageBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public ThroughMessageBuilderExpression At(string domain)
    //    {
    //        return new ThroughMessageBuilderExpression(_builder.SetDomain(domain));
    //    }
    //}

    //public class ThroughMessageBuilderExpression
    //{
    //    private readonly MessageBuilder _builder;

    //    public ThroughMessageBuilderExpression(MessageBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public FromMessageBuilderExpression Through(string port)
    //    {
    //        return new FromMessageBuilderExpression(_builder.SetPort(port));
    //    }
    //}

    //public class FromMessageBuilderExpression
    //{
    //    private readonly MessageBuilder _builder;

    //    public FromMessageBuilderExpression(MessageBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public FinalMessageBuilderExpression From(Account account)
    //    {
    //        return new FinalMessageBuilderExpression(_builder.SetAccount(account));
    //    }
    //}

    //public class FinalMessageBuilderExpression
    //{
    //    private readonly MessageBuilder _builder;

    //    public FinalMessageBuilderExpression(MessageBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public void Typing(bool isTyping)
    //    {
    //        _builder.SendTyping(isTyping);
    //    }

    //    public void Go(string message)
    //    {
    //        _builder.SetBody(message).SendMessage();
    //    }
    //}

    //public class InDialogMessageBuilder
    //{
    //    private string _body;
    //    private Call _call;

    //    public InDialogMessageBuilder SetCall(Call call)
    //    {
    //        Helper.GuardNotNull(call);
    //        Helper.GuardPositiveInt(call.Id);
    //        _call = call;
    //        return this;
    //    }

    //    public InDialogMessageBuilder SetBody(string body)
    //    {
    //        _body = body;
    //        return this;
    //    }

    //    public void SendMessage()
    //    {
    //        //pj_str_t mime = new pj_str_t("plain/text");
    //        //pj_str_t content = new pj_str_t(_body);
    //        //Helper.GuardError(SipUserAgent.Instance.ApiFactory.GetCallApi().pjsua_call_send_im(_call.Id, ref mime, ref content, null, IntPtr.Zero));
    //        SipUserAgent.Instance.SendMessageInDialog(_call, _body);
    //    }

    //    public void SendTyping(bool isTyping)
    //    {
    //        //Helper.GuardError(SipUserAgent.Instance.ApiFactory.GetCallApi().pjsua_call_send_typing_ind(_call.Id, Convert.ToInt32(isTyping), null));
    //        SipUserAgent.Instance.SendTypingInDialog(_call, isTyping);
    //    }
    //}

    //public class OfMessageBuilderExpression
    //{
    //    private readonly InDialogMessageBuilder _builder;

    //    public OfMessageBuilderExpression(InDialogMessageBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public FinalInDialogMessageBuilderExpression Of(Call call)
    //    {
    //        return new FinalInDialogMessageBuilderExpression(_builder.SetCall(call));
    //    }
    //}

    //public class FinalInDialogMessageBuilderExpression
    //{
    //    private readonly InDialogMessageBuilder _builder;

    //    public FinalInDialogMessageBuilderExpression(InDialogMessageBuilder builder)
    //    {
    //        Helper.GuardNotNull(builder);
    //        _builder = builder;
    //    }

    //    public void Typing(bool isTyping)
    //    {
    //        _builder.SendTyping(isTyping);
    //    }

    //    public void Go(string message)
    //    {
    //        _builder.SetBody(message).SendMessage();
    //    }
    //}
}