//using System;
//using NUnit.Framework;
//using pjsip.Interop;
//using pjsip4net.Accounts;
//using pjsip4net.Calls;
//using pjsip4net.Core.Interfaces.ApiProviders;
//using pjsip4net.IM;
//using pjsip4net.Transport;
//using Rhino.Mocks;
//using Is=Rhino.Mocks.Constraints.Is;

//namespace pjsip4net.Tests
//{
//    /// <summary>
//    /// Summary description for MessageBuilderTest
//    /// </summary>
//    [TestFixture]
//    public class MessageBuilderTest
//    {
//        public MessageBuilderTest()
//        {
//            //
//            // TODO: Add constructor logic here
//            //
//        }

//        private MockRepository _mocks;

//        [TestFixtureSetUp]
//        public void MyTestInitialize() 
//        {
//            _mocks = new MockRepository();
//            DefaultImManager.Instance.ApiFactory = _mocks.DynamicMock<IApiFactory>();
//            var b = _mocks.Stub<IBasicApiProvider>();
//            b.Stub(x => x.pjsua_config_default(Arg<pjsua_config>.Is.Anything));
//            b.Stub(p => p.pjsua_verify_sip_url(null)).Constraints(Is.Anything()).Return(0); 
//            DefaultImManager.Instance.ApiFactory.Stub(f => f.GetBasicApi()).Return(b);
//            //SipUserAgent.Instance.ApiFactory.Stub(f => f.GetCallApi()).Return(MockRepository.GenerateStub<ICallApiProvider>());
//            DefaultImManager.Instance.ApiFactory.Stub(f => f.GetMediaApi()).Return(MockRepository.GenerateStub<IMediaApiProvider>());
//            DefaultImManager.Instance.ApiFactory.Stub(f => f.GetImApi()).Return(MockRepository.GenerateStub<IIMApiProvider>());
//            DefaultImManager.Instance.ApiFactory.Stub(f => f.GetAccountApi()).Return(MockRepository.GenerateStub<IAccountApiProvider>());
//            DefaultImManager.Instance.ApiFactory.Stub(f => f.GetTransportApi()).Return(MockRepository.GenerateStub<ITransportApiProvider>());
//        }

//        [TestFixtureTearDown]
//        public void MyTestTeardown()
//        {
//            try
//            {
//                DefaultImManager.Instance.InternalDispose();
//            }
//            catch (InvalidOperationException)
//            {
//            }
//        }

//        [Test]
//        public void MessageBuilder_CorrectArguments_CallsApi()
//        {
//            DefaultImManager.Instance.ApiFactory.Expect(f => f.GetImApi());

//            Account a = new Account(false);
//            a.Id = 0;
//            a.Transport = VoIPTransport.CreateUDPTransport();
//            InstantMessage.New().To("1000").At("74.208.167.77").Through("5081").From(a).SendTyping();
            
//            DefaultImManager.Instance.ApiFactory.VerifyAllExpectations();
//        }

//        [Test, ExpectedException(typeof(ArgumentNullException))]
//        public void MessageBuilder_EmptyDomain_ThrowsException()
//        {
//            InstantMessage.New().To("").At("").Through("");
//            Assert.Fail();// shouldn't get here
//        }

//        [Test]
//        public void InDialogBuilder_CorrectArguments_CallsApi()
//        {
//            DefaultImManager.Instance.ApiFactory.Expect(f => f.GetCallApi()).Return(_mocks.Stub<ICallApiProvider>());
//            //_mocks.ReplayAll();

//            Call c = new Call(new Account(false), 0);
//            using (c.InitializationScope()) { }

//            InstantMessage.New().InDialogOf(c).Send();
            
//            DefaultImManager.Instance.ApiFactory.VerifyAllExpectations();
//        }
//    }
//}