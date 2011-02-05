using NUnit.Framework;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;

namespace pjsip4net.Tests
{
    /// <summary>
    /// Summary description for EqualsTemplateIdentifiableTests
    /// </summary>
    [TestFixture]
    public class given_equals_template_for_IIdentifiable
    {
        class MyClass : IIdentifiable<MyClass>
        {
            public int MyProperty { get; set; }

            #region Implementation of IEquatable<IIdentifiable<MyClass>>

            public bool Equals(IIdentifiable<MyClass> other)
            {
                return EqualsTemplate.Equals(this, other);
            }

            #endregion

            #region Implementation of IIdentifiable<MyClass>

            public int Id { get; set; }

            public bool DataEquals(MyClass other)
            {
                return MyProperty.Equals(other.MyProperty);
            }

            #endregion
        }

        [Test]
        public void when_equals_called_with_equal_objects__should_return_true()
        {
            var sut1 = new MyClass();
            var sut2 = new MyClass();
            Assert.IsTrue(sut1.Equals(sut2));
        }
        
        [Test]
        public void when_equals_called_with_objects_with_different_ids__should_return_false()
        {
            var sut1 = new MyClass();
            var sut2 = new MyClass(){Id = 1};
            Assert.IsFalse(sut1.Equals(sut2));
        }
        
        [Test]
        public void when_equals_called_with_objects_with_different_properties__should_return_false()
        {
            var sut1 = new MyClass();
            var sut2 = new MyClass(){MyProperty = 1};
            Assert.IsFalse(sut1.Equals(sut2));
        }
    }
}