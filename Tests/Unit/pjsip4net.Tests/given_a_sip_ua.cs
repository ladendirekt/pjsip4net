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
            var registry = _fixture.CreateAnonymous<ILocalRegistry>();
            var basicApi = _fixture.CreateAnonymous<IBasicApiProvider>();
            var eventsProvider = _fixture.CreateAnonymous<Mock<IEventsProvider>>();
            eventsProvider.Setup(x => x.Subscribe(It.IsAny<Action<LogRequested>>()));
            var container = _fixture.CreateAnonymous<IContainer>();

            var sut = new DefaultSipUserAgent(basicApi, eventsProvider.Object, registry, container);

            eventsProvider.Verify(x => x.Subscribe(It.IsAny<Action<LogRequested>>()), Times.Once());
        }

        [Test]
        public void when_destroy_called__should_destroy_sip_and_rtp_transports()
        {
            var tpt = _fixture.Freeze<Mock<IVoIPTransportInternal>>();
            var registry = _fixture.CreateAnonymous<Mock<ILocalRegistry>>();
            registry.Setup(x => x.SipTransport).Returns(tpt.Object);
            registry.Setup(x => x.RtpTransport).Returns(tpt.Object);
            var basicApi = _fixture.CreateAnonymous<IBasicApiProvider>();
            var eventsProvider = _fixture.CreateAnonymous<IEventsProvider>();
            tpt.Setup(x => x.InternalDispose());
            var container = _fixture.CreateAnonymous<IContainer>();

            var sut = new DefaultSipUserAgent(basicApi, eventsProvider, registry.Object, container);
            sut.Destroy();

            tpt.Verify(x => x.InternalDispose(), Times.Exactly(2));
        }
    }
}