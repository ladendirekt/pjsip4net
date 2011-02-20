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
    public class given_a_registeringState : _base
    {
        private RegistrationSession _session;
        private Mock<IAccountInternal> _account;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            _account = _fixture.Freeze<Mock<IAccountInternal>>();
            _session = _fixture.CreateAnonymous<RegistrationSession>();
        }

        public override void Teardown()
        {
            base.Teardown();
            _account = null;
            _session = null;
        }

        [Test]
        public void when_ctor_called_should_set_session_registered_state_to_false()
        {
            _fixture.Freeze<Mock<IAccountInternal>>();
            var session = _fixture.Freeze<Mock<RegistrationSession>>();
            var sut = _fixture.Build<RegisteringAccountState>()
                .FromFactory(() => new RegisteringAccountState(session.Object)).CreateAnonymous();

            session.VerifySet(x => x.IsRegistered = It.Is<bool>(x1 => x1.Equals(false)));
        }

        [Test]
        public void when_changeState_called_after_timeout_should_transition_to_timeout_state()
        {
            _account.Setup(x => x.GetAccountInfo()).Returns(new AccountInfo() {Status = SipStatusCode.RequestTimeout});
            var sut = _fixture.Build<RegisteringAccountState>()
                .FromFactory(() => new RegisteringAccountState(_session))
                .CreateAnonymous();

            sut.StateChanged();

            Assert.That(_session.CurrentState, Is.InstanceOf(typeof(TimedOutAccountRegistrationState)));
        }
        
        [Test]
        public void when_changeState_called_after_OK_response_should_transition_to_registered_state()
        {
            _account.Setup(x => x.GetAccountInfo()).Returns(new AccountInfo() {Status = SipStatusCode.Ok});
            var sut = _fixture.Build<RegisteringAccountState>()
                .FromFactory(() => new RegisteringAccountState(_session))
                .CreateAnonymous();

            sut.StateChanged();

            Assert.That(_session.CurrentState, Is.InstanceOf(typeof(RegisteredAccountState)));
        }
        
        [Test]
        public void when_changeState_called_after_any_response_not_equal_to_timeout_and_OK_should_transition_to_generic_unknown_state()
        {
            _account.Setup(x => x.GetAccountInfo()).Returns(new AccountInfo() {Status = SipStatusCode.UseProxy});
            var sut = _fixture.Build<RegisteringAccountState>()
                .FromFactory(() => new RegisteringAccountState(_session))
                .CreateAnonymous();

            sut.StateChanged();

            Assert.That(_session.CurrentState, Is.InstanceOf(typeof(UnknownStatusState)));
        }
    }
    // ReSharper restore InconsistentNaming
}