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
        private readonly IImManager _manager;
        private readonly IAccountManager _accountManager;

        public DefaultMessageBuilder(IImManager manager, IAccountManager accountManager)
        {
            Helper.GuardNotNull(manager);
            _manager = manager;
            _accountManager = accountManager;
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
            _from = account ?? _accountManager.DefaultAccount;
            TransportType ttype = _from.Transport.TransportType;
            _builder.AppendTransportSuffix(ttype);
            return this;
        }

        public IMessageBuilder InDialogOf(ICall call)
        {
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
}