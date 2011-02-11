using NUnit.Framework;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace pjsip4net.Tests
{
    public class _base
    {
        protected IFixture _fixture;

        [SetUp]
        public virtual void Setup()
        {
            _fixture = new Fixture().Customize(new AutoMoqCustomization());
        }

        [TearDown]
        public virtual void Teardown()
        {
            _fixture = null;
        }
    }
}