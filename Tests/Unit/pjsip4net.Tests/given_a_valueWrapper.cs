using NUnit.Framework;
using pjsip4net.Core.Utils;

namespace pjsip4net.Tests
{
    [TestFixture]
    public class given_a_valueWrapper
    {
        [Test]
        public void when_Equals_called_with_same_value_wrapped__should_return_true()
        {
            var vw1 = new ValueWrapper<int>(0);
            Assert.AreEqual(new ValueWrapper<int>(0), vw1);
        }

        [Test]
        public void when_Equals_called_with_different_value_wrapped__should_return_false()
        {
            var vw1 = new ValueWrapper<int>(0);

            Assert.IsFalse(vw1.Equals(new ValueWrapper<int>(1)));
        }

    }
}