using System;
using Moq;
using NUnit.Framework;
using pjsip4net.Accounts;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests.Accounts
{
// ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_an_account : _base
    {
        private Account _sut;

        private void CreateSut()
        {
            _sut = _fixture.Build<Account>().Without(x => x.AccountId).Without(x => x.Credential)
                .Without(x => x.UseSrtp).Without(x => x.SecureSignaling).Without(x => x.Priority)
                .Without(x => x.RegistrarUri).Without(x => x.PublishPresence)
                .Without(x => x.RegistrationTimeout).Without(x => x.KeepAliveInterval)
                .CreateAnonymous();
        }

        private Mock<IAccountApiProvider> CreateProvider()
        {
            var provider = _fixture.Freeze<Mock<IAccountApiProvider>>();
            _fixture.Register<IAccountManagerInternal>(() => _fixture.CreateAnonymous<DefaultAccountManager>());
            return provider;
        }

        [Test, ExpectedException(typeof(InvalidOperationException))]
        public void when_setConfig_called_in_non_initialization_mode__should_throw_exception()
        {
            CreateSut();
            _sut.SetConfig(new AccountConfig());

            Assert.Fail("Should have thrown exception");
        }

        [Test]
        public void when_setConfig_called_during_initialization__should_update_cobfigurable_properties()
        {
            CreateSut();
            using (_sut.InitializationScope())
                _sut.SetConfig(new AccountConfig(){Id = "sip:1@1", RegUri = "sip:2@2"});

            Assert.That(_sut.AccountId, Is.EqualTo("sip:1@1"));
            Assert.That(_sut.RegistrarUri, Is.EqualTo("sip:2@2"));
        }
        
        [Test, ExpectedException(typeof(ArgumentException))]
        public void when_setConfig_called_during_initialization__should_validate_cobfigurable_properties_after_init()
        {
            CreateSut();
            using (_sut.InitializationScope())
                _sut.SetConfig(new AccountConfig(){Id = "1@1", RegUri = "2@2"});

            Assert.Fail("AccountId shouldn't pass validation stage");
        }

        [Test]
        public void when_beginInit_should_call_provider_for_default_config()
        {
            Mock<IAccountApiProvider> provider = CreateProvider();
            CreateSut();

            _sut.BeginInit();
            
            provider.Verify(x => x.GetDefaultConfig());
        }

        [Test, ExpectedException(typeof(InvalidOperationException))]
        public void when_any_public_method_called_without_initialization__should_throw_exception()
        {
            CreateSut();
            _sut.PublishOnline("");
            Assert.Fail();
            _sut.RenewRegistration();
            Assert.Fail();
            _sut.Unregister();
            Assert.Fail();
        }
        
        [Test, ExpectedException(typeof(ObjectDisposedException))]
        public void when_any_public_method_called_after_dispose__should_throw_exception()
        {
            CreateSut();
            _sut.As<IResource>().InternalDispose();
            _sut.PublishOnline("");
            Assert.Fail();
            _sut.RenewRegistration();
            Assert.Fail();
            _sut.Unregister();
            Assert.Fail();
        }

        [Test]
        public void when_publishOnline_and_publishPresence_set__should_call_provider_SetAccountOnlineStatus_with_supplied_note()
        {
            var provider = CreateProvider();
            CreateSut();

            using (_sut.InitializationScope())
            {
                _sut.SetConfig(new AccountConfig() {Id = "sip:1@1", RegUri = "sip:2@2"});
                _sut.PublishPresence = true;
            }

            _sut.PublishOnline("test");

            provider.Verify(
                x => x.SetAccountOnlineStatus(It.Is<int>(x1 => x1.Equals(_sut.Id)), It.Is<bool>(x1 => x1.Equals(true)),
                                              It.Is<RpidElement>(x1 => x1.Note.Equals("test"))));
        }
        
        [Test]
        public void when_publishOnline_and_publishPresence_not_set__should_not_call_provider_SetAccountOnlineStatus()
        {
            var provider = CreateProvider();
            CreateSut();

            using (_sut.InitializationScope())
                _sut.SetConfig(new AccountConfig() {Id = "sip:1@1", RegUri = "sip:2@2"});

            _sut.PublishOnline("test");

            provider.Verify(
                x => x.SetAccountOnlineStatus(It.IsAny<int>(), It.IsAny<bool>(), It.IsAny<RpidElement>()), Times.Never());
        }

        public void when_renewRegistration__should_call_provider()
        {

        }
    }
    // ReSharper restore InconsistentNaming
}