using Moq;
using NUnit.Framework;
using pjsip4net.Accounts;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Interfaces;
using pjsip4net.Transport;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests.Accounts
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_an_account_manager : _base
    {
        [SetUp]
        public void Setup()
        {
            base.Setup();
            _fixture.Customize(new AccountCustomization());
        }

        [Test]
        public void when_register_with_builder_called_should_get_builder_from_container()
        {
            var container = _fixture.Freeze<Mock<IContainer>>();
            var registry = _fixture.Freeze<Mock<IRegistry>>();
            registry.SetupGet(x => x.Container).Returns(container.Object);
            var sut = _fixture.CreateAnonymous<DefaultAccountManager>();
            
            sut.Register(x => x.Register());
            
            container.Verify(x => x.Get<IAccountBuilder>());
        }

        [Test]
        public void when_register_called_should_add_account_to_collection()
        {
            var account = _fixture.CreateAnonymous<Mock<Account>>();
            account.SetupGet(x => x.IsLocal).Returns(false);
            account.SetupGet(x => x.Transport).Returns(_fixture.CreateAnonymous<VoIPTransport>());
            var sut = _fixture.CreateAnonymous<DefaultAccountManager>();

            _fixture.Do<Account, bool>(sut.RegisterAccount);

            Assert.That(sut.Accounts.Count, Is.EqualTo(1));
        }
        
        [Test]
        public void when_unregister_called_should_remove_account_from_collection()
        {
            var account = _fixture.CreateAnonymous<Mock<Account>>();
            account.SetupGet(x => x.IsLocal).Returns(false);
            account.SetupGet(x => x.Transport).Returns(_fixture.CreateAnonymous<VoIPTransport>());
            var sut = _fixture.CreateAnonymous<DefaultAccountManager>();

            _fixture.Do<Account, bool>(sut.RegisterAccount);
            _fixture.Do<Account>(sut.UnregisterAccount);

            Assert.That(sut.Accounts.Count, Is.EqualTo(0));
        }
        
        [Ignore]
        public void when_unregister_all_called_should_clear_accounts_collection()
        {
            var accountMock = new Mock<Account>(MockBehavior.Loose);
            accountMock.SetupGet(x => x.Id).Returns(_fixture.CreateAnonymous<int>());
            _fixture.Build<Account>().FromFactory(() => accountMock.Object);
            var sut = _fixture.CreateAnonymous<DefaultAccountManager>();

            _fixture.Do<Account, bool>(sut.RegisterAccount);
            _fixture.Do<Account, bool>(sut.RegisterAccount);
            _fixture.Do<Account, bool>(sut.RegisterAccount);
            sut.UnRegisterAllAccounts();

            Assert.That(sut.Accounts.Count, Is.EqualTo(0));
        }
    }
    // ReSharper restore InconsistentNaming
}