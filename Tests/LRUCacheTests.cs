using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class LRUCacheTests
    {
        [Fact]
        public void CanEvictOlderEntries()
        {
            var cache = new LruCacheSolution(3);
            cache.Insert(1, 5);
            cache.Insert(2, 10);
            cache.Insert(3, 20);
            cache.Insert(4, 30);

            var expected = -1;
            var actual = cache.LookUp(1);

            Assert.Equal(expected, actual);
        }
    }
}
