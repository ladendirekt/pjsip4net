using pjsip4net.Core;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.IM;
using pjsip4net.IM.Dsl;
using pjsip4net.Interfaces;

namespace pjsip4net.Configuration
{
    public class DefaultComponentConfigurator : IConfigureComponents
    {
        #region Implementation of IConfigureComponents

        public void Configure(IContainer container)
        {
            Helper.GuardNotNull(container);

            container.RegisterAsSingleton<IObjectFactory, DefaultObjectFactory>();
            container.RegisterAsSingleton<IRegistry, IConfigurationContext, DefaultRegistry>();
            container.RegisterAsSingleton<IImManager, IImManagerInternal, DefaultImManager>();
            container.Register<IMessageBuilder, DefaultMessageBuilder>();
            container.Register<IBuddyBuilder, DefaultBuddyBuilder>();
            container.Register<Buddy, Buddy>();
        }

        #endregion
    }
}