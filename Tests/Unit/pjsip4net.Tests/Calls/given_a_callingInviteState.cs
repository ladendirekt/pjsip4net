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
    public class given_a_callingInviteState : _base
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
            new CallingInviteState(null);

            Assert.Fail("Should have thrown exception");
        }

        [Test]
        public void when_ctor_and_call_is_not_incoming__should_raise_ring_event()
        {
            var sut = new CallingInviteState(_session);

            _callMgr.Verify(
                x => x.RaiseRingEvent(It.Is<ICallInternal>(c => ReferenceEquals(c, _call.Object)), It.Is<bool>(b => b)));
        }
        
        [Test]
        public void when_ctor_and_call_is_incoming__should_not_raise_ring_event()
        {
            _call.SetupGet(x => x.IsIncoming).Returns(true);
            var sut = new CallingInviteState(_session);

            _callMgr.Verify(
                x => x.RaiseRingEvent(It.Is<ICallInternal>(c => ReferenceEquals(c, _call.Object)), It.Is<bool>(b => b)),
                Times.Never());
        }
        
        [Test]
        public void when_ctor__should_set_session_inviteState()
        {
            var sut = new CallingInviteState(_session);
            Assert.That(_session.InviteState, Is.EqualTo(InviteState.Calling));
        }
        
        [Test]
        public void when_ctor__should_set_session_isRinging()
        {
            var sut = new CallingInviteState(_session);
            Assert.That(_session.IsRinging, Is.EqualTo(true));
        }

        [Test]
        public void when_changeState_called_after_call_disconnected__should_transition_to_disconnectedState()
        {
            _call.Setup(x => x.GetCallInfo()).Returns(new CallInfo() {State = InviteState.Disconnected});
            var sut =
                _fixture.Build<CallingInviteState>().FromFactory(() => new CallingInviteState(_session)).CreateAnonymous();

            sut.StateChanged();

            Assert.That(_session.CurrentState, Is.InstanceOf(typeof(DisconnectedInviteState)));
        }
        
        [Test]
        public void when_changeState_called_after_call_connected__should_transition_to_confirmedState()
        {
            _call.Setup(x => x.GetCallInfo()).Returns(new CallInfo() {State = InviteState.Confirmed});
            var sut =
                _fixture.Build<CallingInviteState>().FromFactory(() => new CallingInviteState(_session)).CreateAnonymous();

            sut.StateChanged();

            Assert.That(_session.CurrentState, Is.InstanceOf(typeof(ConfirmedInviteState)));
        }
        
        [Test]
        public void when_changeState_called_after_call_connecting__should_transition_to_connectingState()
        {
            _call.Setup(x => x.GetCallInfo()).Returns(new CallInfo() {State = InviteState.Connecting});
            var sut =
                _fixture.Build<CallingInviteState>().FromFactory(() => new CallingInviteState(_session)).CreateAnonymous();

            sut.StateChanged();

            Assert.That(_session.CurrentState, Is.InstanceOf(typeof(ConnectingInviteState)));
        }
    }
    // ReSharper restore InconsistentNaming
}