using System;
using System.Linq;
using NUnit.Framework;
using pjsip4net.Core.Utils;

namespace pjsip4net.Tests
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_bcl_extensions
    {
        [Test]
        public void when_growWithDefaultToCalled_on_empty_collection_should_grow_it_up_to_specified_number_of_items()
        {
            var result = Enumerable.Empty<int>().GrowWithDefaultToTheSizeOf(3);
            Assert.That(result.Count(), Is.EqualTo(3));
        }
        
        [Test]
        public void when_growWithDefaultToCalled_on_collection_with_3_items_to_grow_to_3_should_not_do_anything()
        {
            var result = Enumerable.Repeat(new Int32(), 3).GrowWithDefaultToTheSizeOf(3);
            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void when_growWithDefaultToCalled_with_grow_to_argument_less_then_the_size_of_collection_should_throw_exception()
        {
            Enumerable.Repeat(new Int32(), 3).GrowWithDefaultToTheSizeOf(2);
            Assert.Fail();
        }

        [Test]
        public void when_growWithDefaultTo_called__original_collection_should_go_first()
        {
            var result = Enumerable.Repeat(2, 1).GrowWithDefaultToTheSizeOf(2);
            Assert.That(result.First(), Is.EqualTo(2));
        }
    }
    // ReSharper restore InconsistentNaming
}