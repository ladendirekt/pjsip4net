using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Ploeh.AutoFixture;
using pjsip4net.Core.Interfaces.ApiProviders;
using Moq;
using pjsip4net.Interfaces;
using pjsip4net.Calls;
using pjsip4net.Calls.Dsl;
using pjsip4net.Tests.Calls;
using pjsip4net.Accounts;
using pjsip4net.Tests.Accounts;
using pjsip4net.Core.Data;
using pjsip4net.Core.Utils;

namespace pjsip4net.Tests.Media
{
    [TestFixture]
    public class given_a_call_to_be_recorded : _base
    {
        [SetUp]
        public void Setup()
        {
            _fixture.Customize(new CallCustomization());
            _fixture.Customize(new AccountCustomization());
            _fixture.Register<IAccount>(() => _fixture.CreateAnonymous<Account>());
        }

        [Test]
        public void when_call_constructed_with_dsl__should_create_recorder()
        { 
            //arrange
            var mediaApiMock = _fixture.Freeze<Mock<IMediaApiProvider>>();
            var callApiMock = _fixture.Freeze<Mock<ICallApiProvider>>();
            var callInfoMock = new Mock<CallInfo>();
            callInfoMock.SetupGet(x => x.MediaStatus).Returns(CallMediaState.Active);
            callApiMock.Setup(x => x.GetInfo(It.IsAny<int>())).Returns(callInfoMock.Object);
            var builder = _fixture.CreateAnonymous<DefaultCallBuilder>();

            //act
            var anonymousFileName = _fixture.CreateAnonymous<string>() + ".wav";
            var call = builder.From(_fixture.CreateAnonymous<IAccount>()).To("1").At("localhost").RecordTo(anonymousFileName).Call();
            call.As<Call>().SetId(1);
            call.As<Call>().HandleMediaStateChanged();

            //assert
            mediaApiMock.Verify(x => x.CreateRecorderAndGetId(It.IsAny<string>(), It.Is<uint>(i => i == 0), It.Is<IntPtr>(i => i == IntPtr.Zero),
                It.Is<int>(i => i == 0), It.Is<uint>(i => i == 0)));
        }

        public void when_call_state_changed_to_active__should_start_recording()
        { }

        public void when_call_state_disconnected__should_stop_recording()
        { }
    }
}
