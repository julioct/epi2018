using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class SortAlmostSortedArrayTests
    {
        [Fact]
        public void CanSortArray()
        {
            int[] A = {3, -1, 2, 6, 4, 5, 8};

            int[] expected = {-1, 2, 3, 4, 5, 6, 8};
            var actual = SortAlmostSortedArraySolution.SortApproximatelySortedData(A, 2);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }      
    }
}
