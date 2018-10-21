using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class KthLargestInArrayTests
    {
        [Fact]
        public void CanFindKthLargest()
        {
            int[] A = {3, 2, 1, 5, 4};
            var k = 4;

            var expected = 2;
            var actual = KthLargestInArraySolution.FindKthLargest(k, A);

            Assert.Equal(expected, actual);
        }
    }
}
