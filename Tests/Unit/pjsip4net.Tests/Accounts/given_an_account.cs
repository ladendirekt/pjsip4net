using System;
using System.Reflection;
using Moq;
using NUnit.Framework;
using pjsip4net.Accounts;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Interfaces;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests.Accounts
{
// ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_an_account : _base
    {
        private Account _sut;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            _sut = _fixture.Build<Account>().Without(x => x.AccountId).Without(x => x.Credential)
                .Without(x => x.UseSrtp).Without(x => x.SecureSignaling).Without(x => x.Priority)
                .Without(x => x.RegistrarUri).Without(x => x.PublishPresence)
                .Without(x => x.RegistrationTimeout).Without(x => x.KeepAliveInterval)
                .CreateAnonymous();
        }

        [TearDown]
        public override void Teardown()
        {
            base.Teardown();
            _sut = null;
        }

        [Test, ExpectedException(typeof(InvalidOperationException))]
        public void when_setAccount_called_in_non_initialization_mode_should_throw_exception()
        {
            _sut.SetConfig(new AccountConfig());

            Assert.Fail("Should have thrown exception");
        }

        [Test]
        public void when_setAccount_called_during_initialization_should_update_cobfigurable_properties()
        {
            using (_sut.InitializationScope())
                _sut.SetConfig(new AccountConfig(){Id = "sip:1@1", RegUri = "sip:2@2"});

            Assert.That(_sut.AccountId, Is.EqualTo("sip:1@1"));
            Assert.That(_sut.RegistrarUri, Is.EqualTo("sip:2@2"));
        }
        
        [Test, ExpectedException(typeof(ArgumentException))]
        public void when_setAccount_called_during_initialization_should_validate_cobfigurable_properties_after_init()
        {
            using (_sut.InitializationScope())
                _sut.SetConfig(new AccountConfig(){Id = "1@1", RegUri = "2@2"});

            Assert.Fail("AccountId shouldn't pass validation stage");
        }

        [Ignore]
        public void when_beginInit_should_call_basic_provider_for_default_config()
        {
            var provider = _fixture.CreateAnonymous<Mock<IAccountApiProvider>>();
            
            _sut.BeginInit();
            
            provider.Verify(x => x.GetDefaultConfig());
        }
    }
    // ReSharper restore InconsistentNaming
}