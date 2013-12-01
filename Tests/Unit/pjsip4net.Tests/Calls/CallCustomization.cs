using Moq;
using pjsip4net.Calls;
using pjsip4net.Interfaces;
using Ploeh.AutoFixture;

namespace pjsip4net.Tests.Calls
{
    public class CallCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customize<Call>(x => x.OmitAutoProperties());
            fixture.Freeze<Mock<ICallManagerInternal>>();
            var call = fixture.Freeze<Mock<Call>>();
            fixture.Register(() => call.Object);
        }
    }
}