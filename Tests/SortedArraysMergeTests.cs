using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class SortedArraysMergeTests
    {
        [Fact]
        public void CanMergeSortedArrays()
        {
            int[][] arrays = new int[][]
            {
                new int[]{3,5,7},
                new int[]{0,6},
                new int[]{0,6,28}
            };

            int[] expected = new int[]{0,0,3,5,6,6,7,28};
            var actual = SortedArraysMergeSolution.MergeSortedArrays(arrays);

            for(int i = 0; i < expected.Length; i++){
                Assert.Equal(expected[i], actual[i]);
            }
        }      
    }
}
