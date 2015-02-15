using System.Threading;
using Moq;
using NUnit.Framework;
using pjsip4net.Core;
using pjsip4net.Core.Data.Events;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Media;
using pjsip4net.Testing;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests.Media
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class given_a_wav_player : _base
    {
        [SetUp]
        public void Setup()
        {
            var hub = new EventsProvider();
            _fixture.Register<IEventsProvider>(() => hub);
        }

        [Test]
        public void when_looped_wav_player_created__should_not_raise_event_after_first_round()
        {
            _fixture.Register<IMediaApiProvider>(() => _fixture.CreateAnonymous<MediaApiTestProvider>());
            var sut = _fixture.CreateAnonymous<WavPlayer>();
            var raised = false;
            sut.Completed += (s, ea) => { raised = true; };

            sut.Start(_fixture.CreateAnonymous<string>() + ".wav", true);
            Thread.Sleep(100);

            Assert.IsFalse(raised);
        }
        
        [Test]
        public void when_non_looped_wav_player_created__should_raise_event_at_eof()
        {
            _fixture.Register<IMediaApiProvider>(() => _fixture.CreateAnonymous<MediaApiTestProvider>());
            var sut = _fixture.CreateAnonymous<WavPlayer>();
            var raised = false;
            sut.Completed += (s, ea) => { raised = true; };

            sut.Start(_fixture.CreateAnonymous<string>() + ".wav", false);
            Thread.Sleep(100);

            Assert.IsTrue(raised);
        }
    }
}