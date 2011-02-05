using NUnit.Framework;
using pjsip4net.Core.Utils;

namespace pjsip4net.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestFixture]
    public class given_a_mruCache
    {
        [Test]
        public void when_TryGetValue_called_with_existing_key__should_return_what_it_was_provided()
        {
            var mruCache = new MruCache<ValueWrapper<int>, object>(12);

            object added = new object();
            var key = new ValueWrapper<int>(0);

            mruCache.Add(key, added);

            object res;
            Assert.IsTrue(mruCache.TryGetValue(new ValueWrapper<int>(0), out res));
            Assert.AreEqual(added, res);
        }

        
        [Test]
        public void when_TryGetValue_called_with_nonexistent_key__should_return_false()
        {
            var mruCache = new MruCache<ValueWrapper<int>, object>(12);

            object added = new object();
            var key = new ValueWrapper<int>(0);

            mruCache.Add(key, added);

            object res;
            Assert.IsFalse(mruCache.TryGetValue(new ValueWrapper<int>(1), out res));
            Assert.IsNull(res);
        }

        //[Test]
        //public void TryGetValue_Add2ValueWrappers_ReturnsWhatItWasProvided()
        //{
        //    var mruCache = new MruCache<ValueWrapper<int>, object>(12);

        //    object added = new object();
        //    object added1 = new object();
        //    var key = new ValueWrapper<int>(0);
        //    var key1 = new ValueWrapper<int>(1);

        //    mruCache.Add(key, added);
        //    mruCache.Add(key1, added1);

        //    object res;
        //    Assert.IsTrue(mruCache.TryGetValue(new ValueWrapper<int>(1), out res));
        //    Assert.AreEqual(res, added1);
        //}
    }
}