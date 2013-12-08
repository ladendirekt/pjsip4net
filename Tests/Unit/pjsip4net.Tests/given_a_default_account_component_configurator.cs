using Moq;
using NUnit.Framework;
using pjsip4net.Accounts;
using pjsip4net.Accounts.Dsl;
using pjsip4net.Configuration;
using pjsip4net.Interfaces;

namespace pjsip4net.Tests
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_a_default_account_component_configurator : 
        given_a_component_configurator<DefaultAccountComponentConfigurator>
    {
        [Test]
        public void when_configure_is_called__should_register_default_account_manager_as_singleton_with_internal_interface()
        {
            _container.Setup(x => x.RegisterAsSingleton<IAccountManager, IAccountManagerInternal, DefaultAccountManager>());
            when_configure_called(); 
            _container.Verify(
                x => x.RegisterAsSingleton<IAccountManager, IAccountManagerInternal, DefaultAccountManager>(), Times.Exactly(1));
        }
        
        [Test]
        public void when_configure_is_called__should_register_account_builder_as_transient()
        {
            when_configure_called();
            _container.Verify(
                x => x.Register<IAccountBuilder, DefaultAccountBuilder>(), Times.Exactly(1));
        }
    }
    // ReSharper restore InconsistentNaming
}