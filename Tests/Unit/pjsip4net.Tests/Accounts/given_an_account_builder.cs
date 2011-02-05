using System.Net;
using Moq;
using NUnit.Framework;
using pjsip4net.Accounts.Dsl;
using pjsip4net.Interfaces;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests.Accounts
{
// ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_an_account_builder : _base
    {
        [Test]
        public void when_constructed_from_correct_data_should_create_account_with_supplied_arguments()
        {
            var account = _fixture.Freeze<Mock<IAccountInternal>>();
            account.SetupSet(x => x.AccountId = It.Is<string>(x1 => x1.Equals("sip:test@test.org:5060")));
            account.SetupSet(x => x.RegistrarUri = It.Is<string>(x1 => x1.Equals("sip:test.org:5060")));
            account.SetupSet(
                x =>
                x.Credential =
                It.Is<NetworkCredential>(
                    x1 => x1.UserName.Equals("test") && x1.Password.Equals("test") && x1.Domain.Equals("*")));

            var factory = _fixture.CreateAnonymous<Mock<IObjectFactory>>();
            factory.Setup(x => x.Create<IAccountInternal>()).Returns(account.Object);//shouldn't freeze do this instead?!
            var manager = _fixture.CreateAnonymous<IAccountManagerInternal>();
            var registry = _fixture.CreateAnonymous<ILocalRegistry>();

            var sut = new DefaultAccountBuilder(factory.Object, manager, registry);

            sut.At("test.org").WithExtension("test").WithPassword("test").Through("5060").Register();
            
            account.VerifyAll();
        }
    }
// ReSharper restore InconsistentNaming
}