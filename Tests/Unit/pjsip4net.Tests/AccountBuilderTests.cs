//using System;
//using NUnit.Framework;
//using pjsip4net.Accounts;
//using pjsip4net.Accounts.Dsl;
//using pjsip4net.Interfaces;
//using pjsip4net.Transport;

//namespace pjsip4net.Tests
//{
//    /// <summary>
//    /// Summary description for AccountBuilderTests
//    /// </summary>
//    [TestFixture]
//    public class AccountBuilderTests
//    {
//        public AccountBuilderTests()
//        {
//            //
//            // TODO: Add constructor logic here
//            //
//        }

//        public class AccountBuilderFake : AccountBuilder
//        {
//            internal AccountBuilderFake(IObjectFactory objectFactory, IAccountManagerInternal accountManager, ILocalRegistry localRegistry) 
//                : base(objectFactory, accountManager, localRegistry)
//            {
//            }

//            protected override void InternalRegister(Account account)
//            {
//                //isolate from API
//            }

//            protected override Account CreateAccount()
//            {
//                return new AccountFake(false);
//            }
//        }

//        public class AccountFake : Account
//        {
//            public AccountFake(bool local)
//                : this(local, false)
//            { }

//            public AccountFake(bool local, bool @default)
//                : base(local, @default)
//            { }

//            public override void BeginInit()
//            {
//                _isInitializing = true;
//            }

//            public override void EndInit()
//            {
//                _isInitializing = false;
//                _isInitialized = true;
//            }
//        }

//        [Test]
//        public void Register_WithCorrectData_CreatesCorrectAccount()
//        {
//            //AccountBuilderFake builderMock = MockRepository.GenerateMock<AccountBuilderFake>().;
//            //Expect.Call(builderMock.Register()).CallOriginalMethod();

//            Account result = new AccountBuilderFake().WithExtension("1000").WithPassword("1234").At("74.208.167.44")
//                .Through("5081").Via(VoIPTransport.CreateTLSTransport()).Default().PublishingPresence().Register();

//            //builderMock.VerifyAllExpectations();
//            Assert.IsNotNull(result);
//            //correct login
//            Assert.AreEqual("1000", result.Credential.UserName);
//            //correct password
//            Assert.AreEqual("1234", result.Credential.Password);
//            //correct domain
//            Assert.AreEqual("74.208.167.44", result.RegistrarDomain);
//            //correct port
//            Assert.AreEqual("5081", result.RegistrarPort);
//            //correct transport
//            Assert.IsTrue(result.AccountId.EndsWith(";transport=TLS"));
//        }

//        [Test, ExpectedException(typeof(ArgumentNullException))]
//        public void Register_WithoutDomain_ThrowsArgumentExceprion()
//        {
//            Account result = new AccountBuilderFake().WithExtension("1000").WithPassword("1234").At("")
//                .Through("5081").Via(VoIPTransport.CreateTLSTransport()).Default().PublishingPresence().Register();
//        }
//    }
//}