using System;
using pjsip4net.Core;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Interfaces;

namespace pjsip4net.Transport
{
    public class DefaultVoIPTransportFactory : IVoIPTransportFactory
    {
        private IContainer _container;

        public DefaultVoIPTransportFactory(IContainer container)
        {
            _container = container;
        }

        #region Implementation of IVoIPTransportFactory

        public IVoIPTransport CreateTransport(TransportType transportType)
        {
            return _container.Get<IVoIPTransport>(transportType.ToString());
        }

        public IVoIPTransport CreateTransport(TransportType transportType, TransportConfig config)
        {
            var tpt = CreateTransport(transportType);
            using (((Initializable)tpt).InitializationScope())
                if (config != null) tpt.SetConfig(config);
            return tpt;
        }

        #endregion
    }
}