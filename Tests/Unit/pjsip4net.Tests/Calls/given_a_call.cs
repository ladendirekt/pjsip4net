using System;
using Moq;
using NUnit.Framework;
using pjsip4net.Calls;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Interfaces;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests.Calls
{
// ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_a_call : _base
    {
        private Call _sut;
        private Mock<ICallApiProvider> _provider;

        [SetUp]
        public void Setup()
        {
            _sut = _fixture.Build<Call>().OmitAutoProperties().CreateAnonymous();
            _provider = _fixture.Freeze<Mock<ICallApiProvider>>();
            _provider.Setup(x => x.GetInfo(It.IsAny<int>()))
                .Returns(new CallInfo() { MediaStatus = CallMediaState.Active });
            _fixture.Register<ICallManagerInternal>(() => _fixture.CreateAnonymous<DefaultCallManager>());
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void when_transfer_with_invalid_uri__should_raise_exception()
        {
            //arrange
            //act
            _sut.Transfer("sipuri");

            //assert
            Assert.Fail("should have validated uri");
        }
        
        [Test]
        public void when_transfer_in_none_media_state__should_not_delegate_call_to_provider()
        {
            //arrange
            var provider = _fixture.Freeze<Mock<ICallApiProvider>>();
            provider.Setup(x => x.GetInfo(It.IsAny<int>()))
                .Returns(new CallInfo() {MediaStatus = CallMediaState.Active});
            _fixture.Register<ICallManagerInternal>(() => _fixture.CreateAnonymous<DefaultCallManager>());
            var sut = _fixture.Build<Call>().OmitAutoProperties().CreateAnonymous();

            //act
            sut.Transfer("sip:sip@sip");

            //assert
            provider.Verify(x => x.TransferCall(It.Is<int>(x1 => x1 == sut.Id), It.Is<string>(x1 => x1 == "sip:sip@sip")), Times.Never());
        }
        
        [Test]
        public void when_transfer_in_active_media_state__should_delegate_call_to_provider()
        {
            //arrange
            var provider = _fixture.Freeze<Mock<ICallApiProvider>>();
            provider.Setup(x => x.GetInfo(It.IsAny<int>()))
                .Returns(new CallInfo() {MediaStatus = CallMediaState.Active});
            _fixture.Register<ICallManagerInternal>(() => _fixture.CreateAnonymous<DefaultCallManager>());
            var sut = _fixture.Build<Call>().OmitAutoProperties().CreateAnonymous();
            sut.SetId(_fixture.CreateAnonymous<int>());
            sut.HandleMediaStateChanged();

            //act
            sut.Transfer("sip:sip@sip");

            //assert
            provider.Verify(x => x.TransferCall(It.Is<int>(x1 => x1 == sut.Id), It.Is<string>(x1 => x1 == "sip:sip@sip")), Times.Once());
        }
    }
// ReSharper restore InconsistentNaming
}