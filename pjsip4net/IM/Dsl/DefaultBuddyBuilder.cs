using pjsip4net.Core;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.IM.Dsl
{
    internal class DefaultBuddyBuilder : IBuddyBuilder
    {
        private readonly SipUriBuilder _uriBuilder = new SipUriBuilder();
        private bool _subscribe;
        private IImManagerInternal _imManager;
        private IObjectFactory _objectFactory;

        public DefaultBuddyBuilder(IImManagerInternal imManager, IObjectFactory objectFactory)
        {
            Helper.GuardNotNull(imManager);
            Helper.GuardNotNull(objectFactory);
            _imManager = imManager;
            _objectFactory = objectFactory;
        }

        public IBuddyBuilder WithName(string name)
        {
            _uriBuilder.AppendExtension(name);
            return this;
        }

        public IBuddyBuilder Through(string port)
        {
            _uriBuilder.AppendPort(port);
            return this;
        }

        public IBuddyBuilder At(string domain)
        {
            _uriBuilder.AppendDomain(domain);
            return this;
        }

        public IBuddyBuilder Via(TransportType transport)
        {
            _uriBuilder.AppendTransportSuffix(transport);
            return this;
        }

        public IBuddyBuilder Subscribing()
        {
            _subscribe = true;
            return this;
        }

        public IBuddy Register()
        {
            var buddy = CreateBuddy();
            using (buddy.InitializationScope())
            {
                buddy.Uri = _uriBuilder.ToString();
                buddy.Subscribe = _subscribe;
            }

            InternalRegister(buddy);
            return buddy;
        }

        protected IBuddyInternal CreateBuddy()
        {
            return _objectFactory.Create<IBuddyInternal>();
        }

        private void InternalRegister(IBuddyInternal buddy)
        {
            _imManager.RegisterBuddy(buddy);
        }
    }
}