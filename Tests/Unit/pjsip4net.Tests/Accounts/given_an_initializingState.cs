using Moq;
using NUnit.Framework;
using pjsip4net.Accounts;
using pjsip4net.Core.Data;
using pjsip4net.Interfaces;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests.Accounts
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_an_initializingState : _base
    {
        private Mock<Account> _account;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            _fixture.Customize(new AccountCustomization());
            _account = _fixture.CreateAnonymous<Mock<Account>>();
        }

        [Test]
        public void when_state_changed_and_account_is_local_should_transition_to_registered_state()
        {
            _account = _fixture.Freeze<Mock<Account>>();
            _account.SetupGet(x => x.IsLocal).Returns(true);
            var session = _fixture.CreateAnonymous<RegistrationSession>();
            
            session.CurrentState.StateChanged();

            Assert.That(session.CurrentState, Is.InstanceOf(typeof(RegisteredAccountState)));
        }
        
        [Test]
        public void when_state_changed_and_account_is_not_local_and_status_is_trying_should_transition_to_registering_state()
        {
            _account.SetupGet(x => x.IsLocal).Returns(false);
            _account.Setup(x => x.GetAccountInfo()).Returns(new AccountInfo() {Status = SipStatusCode.Trying});
            var session = _fixture.CreateAnonymous<RegistrationSession>();
            
            session.CurrentState.StateChanged();

            Assert.That(session.CurrentState, Is.InstanceOf(typeof(RegisteringAccountState)));
        }
        
        [Test]
        public void when_state_changed_and_account_is_not_local_and_status_is_not_trying_should_transition_to_generic_unknown_state()
        {
            _account.SetupGet(x => x.IsLocal).Returns(false);
            _account.Setup(x => x.GetAccountInfo()).Returns(new AccountInfo() {Status = SipStatusCode.CallBeingForwarded});
            var session = _fixture.CreateAnonymous<RegistrationSession>();
            
            session.CurrentState.StateChanged();

            Assert.That(session.CurrentState, Is.InstanceOf(typeof(UnknownStatusState)));
        }
    }
    // ReSharper restore InconsistentNaming
}