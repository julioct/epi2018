using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class IntersectSortedArraysTests
    {
        [Fact]
        public void CanIntersectSortedArrays()
        {
            int[] A = {2,3,3,5,5,6,7,7,8,12};
            int[] B = {5,5,6,8,8,9,10,10};

            var expected = new List<int>(new int[]{5,6,8});
            var actual = IntersectSortedArraysSolution.IntersectTwoSortedArrays(A, B);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }      
    }
}
