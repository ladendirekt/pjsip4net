using Moq;
using pjsip4net.Accounts;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Transport;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests.Accounts
{
    public class AccountCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customize<VoIPTransport>(x => x.FromFactory<ITransportApiProvider>(t => new UdpTransport(t)));
            fixture.Customize<Account>(x => x.OmitAutoProperties());
            var account = fixture.Freeze<Mock<Account>>();
            account.SetupGet(x => x.Id).Returns(fixture.CreateAnonymous<int>());
            fixture.Register(() => account.Object);
        }
    }
}