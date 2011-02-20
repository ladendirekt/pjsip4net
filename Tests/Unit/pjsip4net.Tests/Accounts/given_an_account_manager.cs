using Moq;
using NUnit.Framework;
using pjsip4net.Accounts;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Interfaces;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests.Accounts
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_an_account_manager : _base
    {
        [Test]
        public void when_register_with_builder_called_should_get_builder_from_container()
        {
            var container = _fixture.Freeze<Mock<IContainer>>();
            var registry = _fixture.Freeze<Mock<ILocalRegistry>>();
            registry.SetupGet(x => x.Container).Returns(container.Object);
            var sut = _fixture.CreateAnonymous<DefaultAccountManager>();
            
            sut.Register(x => x.Register());
            
            container.Verify(x => x.Get<IAccountBuilder>());
        }

        [Test]
        public void when_register_called_should_add_account_to_collection()
        {
            var account = _fixture.Freeze<Mock<IAccountInternal>>();
            account.SetupGet(x => x.IsLocal).Returns(false);
            var sut = _fixture.CreateAnonymous<DefaultAccountManager>();

            _fixture.Do<IAccountInternal, bool>(sut.RegisterAccount);

            Assert.That(sut.Accounts.Count, Is.EqualTo(1));
        }
        
        [Test]
        public void when_unregister_called_should_remove_account_from_collection()
        {
            var account = _fixture.Freeze<Mock<IAccountInternal>>();
            account.SetupGet(x => x.IsLocal).Returns(false);
            var sut = _fixture.CreateAnonymous<DefaultAccountManager>();

            _fixture.Do<IAccountInternal, bool>(sut.RegisterAccount);
            _fixture.Do<IAccountInternal>(sut.UnregisterAccount);

            Assert.That(sut.Accounts.Count, Is.EqualTo(0));
        }
        
        [Ignore]
        public void when_unregister_all_called_should_clear_accounts_collection()
        {
            var accountMock = new Mock<IAccountInternal>(MockBehavior.Loose);
            accountMock.SetupGet(x => x.Id).Returns(_fixture.CreateAnonymous<int>());
            _fixture.Build<IAccountInternal>().FromFactory(() => accountMock.Object);
            var sut = _fixture.CreateAnonymous<DefaultAccountManager>();

            _fixture.Do<IAccountInternal, bool>(sut.RegisterAccount);
            _fixture.Do<IAccountInternal, bool>(sut.RegisterAccount);
            _fixture.Do<IAccountInternal, bool>(sut.RegisterAccount);
            sut.UnRegisterAllAccounts();

            Assert.That(sut.Accounts.Count, Is.EqualTo(0));
        }
    }
    // ReSharper restore InconsistentNaming
}