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
    public class given_an_unknownState : _base
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
            var session = _fixture.Freeze<Mock<RegistrationSession>>();
            var sut = _fixture.Build<UnknownStatusState>()
                .FromFactory(() => new UnknownStatusState(session.Object,
                                                          _fixture.CreateAnonymous<SipStatusCode>(),
                                                          _fixture.CreateAnonymous<string>()))
                .CreateAnonymous();

            session.VerifySet(x => x.IsRegistered = It.Is<bool>(x1 => x1.Equals(false)));
        }
        
        [Test]
        public void when_ctor_called_should_acquire_status_registered_state_to_false()
        {
            var anonymousStatus = _fixture.Freeze(SipStatusCode.TooManyHops);
            var anonymousStatusText = _fixture.Freeze(SipStatusCode.TooManyHops.ToString());
            var sut = _fixture.CreateAnonymous<UnknownStatusState>();

            Assert.That(sut.StatusCode, Is.EqualTo(anonymousStatus));
            Assert.That(sut.StatusText, Is.EqualTo(anonymousStatusText));
        }

        [Test]
        public void when_changeState_called_after_timeout_should_transition_to_timeout_state()
        {
            _account.Setup(x => x.GetAccountInfo()).Returns(new AccountInfo() { Status = SipStatusCode.RequestTimeout });
            var sut = _fixture.Build<UnknownStatusState>()
                .FromFactory(() => new UnknownStatusState(_session, _fixture.CreateAnonymous<SipStatusCode>(),
                                                          _fixture.CreateAnonymous<string>()))
                .CreateAnonymous();

            sut.StateChanged();

            Assert.That(_session.CurrentState, Is.InstanceOf(typeof(TimedOutAccountRegistrationState)));
        }

        [Test]
        public void when_changeState_called_after_OK_response_should_transition_to_registered_state()
        {
            _account.Setup(x => x.GetAccountInfo()).Returns(new AccountInfo() { Status = SipStatusCode.Ok });
            var sut = _fixture.Build<UnknownStatusState>()
                .FromFactory(() => new UnknownStatusState(_session, _fixture.CreateAnonymous<SipStatusCode>(),
                                                          _fixture.CreateAnonymous<string>()))
                .CreateAnonymous();

            sut.StateChanged();

            Assert.That(_session.CurrentState, Is.InstanceOf(typeof(RegisteredAccountState)));
        }

        [Test]
        public void when_changeState_called_after_trying_response_should_transition_to_registering_state()
        {
            _account.Setup(x => x.GetAccountInfo()).Returns(new AccountInfo() { Status = SipStatusCode.Trying });
            var sut = _fixture.Build<UnknownStatusState>()
                .FromFactory(() => new UnknownStatusState(_session, _fixture.CreateAnonymous<SipStatusCode>(),
                                                          _fixture.CreateAnonymous<string>()))
                .CreateAnonymous();

            sut.StateChanged();

            Assert.That(_session.CurrentState, Is.InstanceOf(typeof(RegisteringAccountState)));
        }

        [Test]
        public void when_changeState_called_after_any_response_not_equal_to_timeout_OK_or_trying_should_not_transition_from_unknown_state()
        {
            _account.Setup(x => x.GetAccountInfo()).Returns(new AccountInfo {Status = SipStatusCode.UseProxy});
            var sut = _fixture.Build<UnknownStatusState>()
                .FromFactory(() => new UnknownStatusState(_session, _fixture.CreateAnonymous<SipStatusCode>(),
                                                          _fixture.CreateAnonymous<string>()))
                .CreateAnonymous();

            sut.StateChanged();

            Assert.That(_session.CurrentState, Is.InstanceOf(typeof(UnknownStatusState)));
        }
    }
    // ReSharper restore InconsistentNaming
}