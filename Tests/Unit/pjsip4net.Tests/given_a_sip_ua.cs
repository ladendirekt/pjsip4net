using System;
using Moq;
using NUnit.Framework;
using pjsip4net.Core.Data;
using pjsip4net.Core.Data.Events;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Interfaces;
using pjsip4net.Transport;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_a_sip_ua : _base
    {
        [Test]
        public void when_ctor_called__should_subscribe_to_log_event()
        {
            _fixture.Freeze<IRegistry>();
            _fixture.Freeze<IBasicApiProvider>();
            _fixture.Freeze<IContainer>();
            var eventsProvider = _fixture.Freeze<Mock<IEventsProvider>>();

            _fixture.CreateAnonymous<DefaultSipUserAgent>();

            eventsProvider.Verify(x => x.Subscribe(It.IsAny<Action<LogRequested>>()), Times.Once());
        }

        [Ignore("temporarily delegated this to pjsip stack")]
        public void when_destroy_called__should_destroy_sip_and_rtp_transports()
        {
            var tpt = _fixture.CreateAnonymous<VoIPTransport>();
            var registry = _fixture.Freeze<Mock<IRegistry>>();
            registry.SetupGet(x => x.SipTransport).Returns(tpt);
            registry.SetupGet(x => x.RtpTransport).Returns(tpt);
            _fixture.Freeze<IBasicApiProvider>();
            _fixture.Freeze<IEventsProvider>();
            _fixture.Freeze<IContainer>();

            Assert.AreEqual(false, tpt.IsDisposed);

            var sut = _fixture.CreateAnonymous<DefaultSipUserAgent>();
            sut.SetManagers(_fixture.CreateAnonymous<IImManager>(), _fixture.CreateAnonymous<ICallManager>(),
                            _fixture.CreateAnonymous<IAccountManager>(), _fixture.CreateAnonymous<IMediaManager>());
            sut.Destroy();

            Assert.AreEqual(true, tpt.IsDisposed);
        }
        
        [Test]
        public void when_destroy_called__should_delegate_sip_stack_destroy_to_api()
        {
            var basicApi = _fixture.CreateAnonymous<Mock<IBasicApiProvider>>();
            var eventsProvider = _fixture.CreateAnonymous<IEventsProvider>();

            var sut = new DefaultSipUserAgent(basicApi.Object, eventsProvider, _fixture.CreateAnonymous<LoggingConfig>());
            sut.Destroy();

            basicApi.Verify(x => x.Destroy(), Times.Once());
        }
    }
    // ReSharper restore InconsistentNaming
}