using System;
using Moq;
using NUnit.Framework;
using pjsip4net.Calls;
using pjsip4net.Core.Data;
using pjsip4net.Interfaces;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests.Calls
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_a_nullInviteState : _base
    {
        private InviteSession _session;
        private Mock<ICallInternal> _call;
        private Mock<ICallManagerInternal> _callMgr;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            _callMgr = _fixture.Freeze<Mock<ICallManagerInternal>>();
            _call = _fixture.Freeze<Mock<ICallInternal>>();
            _session = _fixture.CreateAnonymous<InviteSession>();
        }

        [TearDown]
        public override void Teardown()
        {
            base.Teardown();
            _call = null;
            _session = null;
        }

        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void when_ctor_with_session_equal_to_null__should_throw_exception()
        {
            new NullInviteState(null);

            Assert.Fail("Should have thrown exception");
        }

        [Test]
        public void when_ctor__should_set_session_inviteState()
        {
            var sut = new NullInviteState(_session);
            Assert.That(_session.InviteState, Is.EqualTo(InviteState.None));
        }

        [Test]
        public void when_changeState_called_after_call_disconnected__should_transition_to_disconnectedState()
        {
            _call.Setup(x => x.GetCallInfo()).Returns(new CallInfo() {State = InviteState.Disconnected});
            var sut =
                _fixture.Build<NullInviteState>().FromFactory(() => new NullInviteState(_session)).CreateAnonymous();

            sut.StateChanged();

            Assert.That(_session.CurrentState, Is.InstanceOf(typeof(DisconnectedInviteState)));
        }
        
        [Test]
        public void when_changeState_called_after_any_response_other_then_disconnected__should_transition_to_callingState()
        {
            _call.Setup(x => x.GetCallInfo()).Returns(new CallInfo() {State = InviteState.Early});
            var sut =
                _fixture.Build<NullInviteState>().FromFactory(() => new NullInviteState(_session)).CreateAnonymous();

            sut.StateChanged();

            Assert.That(_session.CurrentState, Is.InstanceOf(typeof(CallingInviteState)));
        }
    }
    // ReSharper restore InconsistentNaming
}