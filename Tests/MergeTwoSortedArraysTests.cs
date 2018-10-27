using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class MergeTwoSortedArraysTests
    {
        [Fact]
        public void CanMergeTwoSortedArrays()
        {
            int[] A = {3, 13, 17, 0, 0, 0, 0, 0};
            int[] B = {3, 7, 11, 19};

            int[] expected = {3, 3, 7, 11, 13, 17, 19, 0};
            
            MergeTwoSortedArraysSolution.MergeTwoSortedArrays(A, 3, B, 4);

            for(var i = 0; i < expected.Length; i++){
                Assert.Equal(expected[i], A[i]);
            }
        }
    }
}
