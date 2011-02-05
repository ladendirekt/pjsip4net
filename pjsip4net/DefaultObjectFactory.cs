using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net
{
    public class DefaultObjectFactory : IObjectFactory
    {
        private IContainer _container;

        public DefaultObjectFactory(IContainer container)
        {
            Helper.GuardNotNull(container);
            _container = container;
        }

        #region Implementation of IObjectFactory

        public T Create<T>()
        {
            return _container.Get<T>();
        }

        #endregion
    }
}