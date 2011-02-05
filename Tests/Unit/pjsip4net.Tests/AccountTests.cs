//using System;
//using System.Collections.ObjectModel;
//using System.Linq;
//using NUnit.Framework;
//using pjsip4net.Accounts;
//using pjsip4net.Calls;
//using pjsip4net.Core.Data;
//using pjsip4net.Core.Interfaces;
//using pjsip4net.Core.Interfaces.ApiProviders;
//using pjsip4net.Core.Utils;
//using pjsip4net.IM;
//using pjsip4net.Interfaces;
//using Rhino.Mocks;
//using Is=Rhino.Mocks.Constraints.Is;

//namespace pjsip4net.Tests
//{
//    /// <summary>
//    /// Summary description for CallTests
//    /// </summary>
//    [TestFixture]
//    public class AccountTests
//    {
//        public AccountTests()
//        {
//            //
//            // TODO: Add constructor logic here
//            //
//        }

//        public class FakeConfigurator : IConfigurationProvider
//        {
//            #region Implementation of IConfigurationProvider

//            public void Configure(UaConfig config, MediaConfig mediaConfig, LoggingConfig loggingConfig)
//            {
//                config.SetPreConfiguredAccounts(Enumerable.Repeat(new Account(false, true){Id = 1}, 1));
//            }

//            public void Store(UaConfig config, MediaConfig mediaConfig, LoggingConfig loggingConfig)
//            {
//                throw new NotImplementedException();
//            }

//            #endregion
//        }

//        [TestFixtureSetUp]
//        public void Initialize()
//        {
//            DefaultImManager.Instance.ApiFactory = MockRepository.GenerateStub<IApiFactory>();
//            DefaultImManager.Instance.ApiFactory.Stub(f => f.GetCallApi()).Return(MockRepository.GenerateStub<ICallApiProvider>());
//            var bp = MockRepository.GenerateStub<IBasicApiProvider>();
//            bp.Stub(p => p.pjsua_verify_sip_url(null)).Constraints(Is.Anything()).Return(0);
//            DefaultImManager.Instance.ApiFactory.Stub(f => f.GetBasicApi()).Return(bp);
//            DefaultImManager.Instance.ApiFactory.Stub(f => f.GetCallApi()).Return(MockRepository.GenerateStub<ICallApiProvider>());
//            DefaultImManager.Instance.ApiFactory.Stub(f => f.GetMediaApi()).Return(MockRepository.GenerateStub<IMediaApiProvider>());
//            DefaultImManager.Instance.ApiFactory.Stub(f => f.GetImApi()).Return(MockRepository.GenerateStub<IIMApiProvider>());
//            DefaultImManager.Instance.ApiFactory.Stub(f => f.GetAccountApi()).Return(MockRepository.GenerateStub<IAccountApiProvider>());
//            DefaultImManager.Instance.ApiFactory.Stub(f => f.GetTransportApi()).Return(MockRepository.GenerateStub<ITransportApiProvider>());
//        }

//        [Test]
//        public void IsInUse_AfterCallCreated_ReturnsTrue()
//        {
//            Account a = new Account(false);
//            Call c = new Call(a, 0);
//            using (c.InitializationScope()) { }//locks account after succesful initialization

//            Assert.IsTrue(a.IsInUse);
//        }

//        [Test]
//        public void IsInUse_AfterCallDisposed_ReturnsFalse()
//        {
//            Account a = new Account(false);
//            Call c = new Call(a, 0);
//            using (c.InitializationScope()) { }//locks account after succesful initialization

//            Assert.IsTrue(a.IsInUse);

//            c.InternalDispose();

//            Assert.IsFalse(a.IsInUse);
//        }

//        [Test]
//        public void RegisterPreConfigured_AllSet_HasTransport()
//        {
//            SingletonHolder<IAccountManagerInternal>.SetInstanceInjector(
//                () => MockRepository.GenerateStub<IAccountManagerInternal>());
//            DefaultImManager.Instance.ConfigurationProvider = new FakeConfigurator();
//            DefaultImManager.Instance.BeginInit();
//            DefaultImManager.Instance.EndInit();
//            SingletonHolder<IAccountManager>.Instance.Stub(am => am.RegisterAccount(new Account(true), true))
//                .Constraints(Is.Anything(), Is.Anything());
//            SingletonHolder<IAccountManager>.Instance.Stub(am => am.Accounts).Return(
//                new ReadOnlyCollection<Account>(DefaultImManager.Instance.Config.GetPreConfiguredAccounts()));
//            DefaultImManager.Instance.Start();

//            Assert.IsTrue(DefaultImManager.Instance.AccountManager.Accounts.All(a => a.Transport != null));
//        }
//    }
//}