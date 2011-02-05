using pjsip4net.Core;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.IM.Dsl
{
    internal class DefaultBuddyBuilder : IBuddyBuilder
    {
        private string _name;
        private string _port;
        private string _domain;
        private TransportType _transport;
        private bool _subscribe;
        private IImManagerInternal _imManager;
        private IObjectFactory _objectFactory;

        public DefaultBuddyBuilder(IImManagerInternal imManager, IObjectFactory objectFactory)
        {
            Helper.GuardNotNull(imManager);
            Helper.GuardNotNull(objectFactory);
            _imManager = imManager;
            _objectFactory = objectFactory;
            _transport = TransportType.Udp;
        }

        public IBuddyBuilder WithName(string name)
        {
            Helper.GuardNotNullStr(name);
            _name = name;
            return this;
        }

        public IBuddyBuilder Through(string port)
        {
            Helper.GuardNotNullStr(port);
            Helper.GuardPositiveInt(int.Parse(port));
            _port = port;
            return this;
        }

        public IBuddyBuilder At(string domain)
        {
            Helper.GuardNotNullStr(domain);
            _domain = domain;
            return this;
        }

        public IBuddyBuilder Via(TransportType transport)
        {
            _transport = transport;
            return this;
        }

        public IBuddyBuilder Subscribing()
        {
            _subscribe = true;
            return this;
        }

        public IBuddy Register()
        {
            Helper.GuardNotNullStr(_name);
            //Helper.GuardNotNullStr(_domain);
            var buddy = CreateBuddy();
            using (buddy.InitializationScope())
            {
                var uriBuilder = new SipUriBuilder().AppendExtension(_name).AppendDomain(_domain)
                .AppendPort(string.IsNullOrEmpty(_port) ? "5060" : _port).AppendTransportSuffix(
                _transport);
                buddy.Uri = uriBuilder.ToString();
                buddy.Subscribe = _subscribe;
            }

            InternalRegister(buddy);
            return buddy;
        }

        protected virtual IBuddyInternal CreateBuddy()
        {
            return _objectFactory.Create<IBuddyInternal>();
        }

        private void InternalRegister(IBuddyInternal buddy)
        {
            _imManager.RegisterBuddy(buddy);
        }
    }
}