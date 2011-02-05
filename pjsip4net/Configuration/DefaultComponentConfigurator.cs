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
            container.RegisterAsSingleton<IObjectFactory, DefaultObjectFactory>()
                .RegisterAsSingleton<ILocalRegistry, DefaultLocalRegistry>()
                .RegisterAsSingleton(container.Get<ILocalRegistry>() as IConfigurationContext)
                
                .RegisterAsSingleton<IImManager, DefaultImManager>()
                .RegisterAsSingleton(container.Get<IImManager>().As<IImManagerInternal>())
                .Register<IMessageBuilder, DefaultMessageBuilder>()
                .Register<IBuddyBuilder, DefaultBuddyBuilder>()
                .Register<IBuddyInternal, Buddy>();

            container.RegisterAsSingleton<ISipUserAgent, DefaultSipUserAgent>()
                .RegisterAsSingleton(container.Get<ISipUserAgent>() as ISipUserAgentInternal);
        }

        #endregion
    }
}