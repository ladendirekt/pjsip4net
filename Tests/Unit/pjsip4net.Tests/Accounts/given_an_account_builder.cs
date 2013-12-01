using System.Net;
using Moq;
using NUnit.Framework;
using pjsip4net.Accounts;
using pjsip4net.Accounts.Dsl;
using pjsip4net.Interfaces;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests.Accounts
{
// ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_an_account_builder : _base
    {
        private Mock<Account> _account;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            _fixture.Customize(new AccountCustomization());
            _account = _fixture.CreateAnonymous<Mock<Account>>();
        }

        [Test]
        public void when_constructed_from_correct_data_should_create_account_with_supplied_arguments()
        {
            //arrange
            var factory = _fixture.Freeze<Mock<IObjectFactory>>();
            factory.Setup(x => x.Create<Account>()).Returns(_account.Object);

            var sut = _fixture.CreateAnonymous<DefaultAccountBuilder>();

            //act
            var result = sut.At("test.org").WithExtension("test").WithPassword("test").Through("5060").Register();
            
            //assert
            Assert.AreEqual("sip:test@test.org:5060", result.AccountId);
            Assert.AreEqual("sip:test.org:5060", result.RegistrarUri);
            Assert.AreEqual("test", result.Credential.UserName);
            Assert.AreEqual("test", result.Credential.Password);
            Assert.AreEqual("*", result.Credential.Domain);
        }

        [Test]
        public void when_account_exposed_should_use_supplied_arguments()
        {
            //arrange
            _account.SetupAllProperties();
            var factory = _fixture.Freeze<Mock<IObjectFactory>>();
            factory.Setup(x => x.Create<Account>()).Returns(_account.Object);

            var sut = _fixture.CreateAnonymous<DefaultAccountBuilder>();

            //act
            var anonymous = _fixture.CreateAnonymous<int>();
            var result =
                sut.At("test.org")
                    .WithExtension("test")
                    .WithPassword("test")
                    .ExposeAccount(x => x.Priority = anonymous)
                    .Register();
            
            //assert
            Assert.AreEqual(anonymous, result.Priority);
        }
    }
// ReSharper restore InconsistentNaming
}