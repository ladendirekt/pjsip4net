using System;
using Moq;
using NUnit.Framework;
using pjsip4net.Core.Data.Events;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Interfaces;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests
{
    [TestFixture]
    public class given_a_sip_ua : _base
    {
        [Test]
        public void when_ctor_called__should_subscribe_to_log_event()
        {
            _fixture.Freeze<ILocalRegistry>();
            _fixture.Freeze<IBasicApiProvider>();
            _fixture.Freeze<IContainer>();
            var eventsProvider = _fixture.Freeze<Mock<IEventsProvider>>();

            var sut = _fixture.CreateAnonymous<DefaultSipUserAgent>();

            eventsProvider.Verify(x => x.Subscribe(It.IsAny<Action<LogRequested>>()), Times.Once());
        }

        [Test]
        public void when_destroy_called__should_destroy_sip_and_rtp_transports()
        {
            var tpt = _fixture.Freeze<Mock<IVoIPTransportInternal>>();
            var registry = _fixture.Freeze<Mock<ILocalRegistry>>();
            registry.SetupGet(x => x.SipTransport).Returns(tpt.Object);
            registry.SetupGet(x => x.RtpTransport).Returns(tpt.Object);
            _fixture.Freeze<IBasicApiProvider>();
            _fixture.Freeze<IEventsProvider>();
            _fixture.Freeze<IContainer>();

            var sut = _fixture.CreateAnonymous<DefaultSipUserAgent>();
            sut.SetManagers(_fixture.CreateAnonymous<IImManager>(), _fixture.CreateAnonymous<ICallManager>(),
                            _fixture.CreateAnonymous<IAccountManager>(), _fixture.CreateAnonymous<IMediaManager>());
            sut.Destroy();

            tpt.Verify(x => x.InternalDispose(), Times.Exactly(2));
        }
        
        [Test]
        public void when_destroy_called__should_delegate_sip_stack_destroy_to_api()
        {
            var registry = _fixture.CreateAnonymous<Mock<ILocalRegistry>>();
            var basicApi = _fixture.CreateAnonymous<Mock<IBasicApiProvider>>();
            var eventsProvider = _fixture.CreateAnonymous<IEventsProvider>();
            var container = _fixture.CreateAnonymous<IContainer>();

            var sut = new DefaultSipUserAgent(basicApi.Object, eventsProvider, registry.Object, container);
            sut.Destroy();

            basicApi.Verify(x => x.Destroy(), Times.Once());
        }
    }
}