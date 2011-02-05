using pjsip4net.Accounts;
using pjsip4net.Accounts.Dsl;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Configuration
{
    public class DefaultAccountComponentConfigurator : IConfigureComponents
    {
        public void Configure(IContainer container)
        {
            Helper.GuardNotNull(container);
            container.RegisterAsSingleton<IAccountManager, DefaultAccountManager>();
            container.RegisterAsSingleton(container.Get<IAccountManager>() as IAccountManagerInternal);
            container.Register<IAccountBuilder, DefaultAccountBuilder>();
            container.Register<IAccountInternal, Account>();
        }
    }
}