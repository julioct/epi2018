using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class DutchNationalFlagTests
    {
        [Fact]
        public void CanPartition01()
        {
            int[] A = {0, 1, 2, 0, 2, 1, 1};
            var pivotIndex = 1;

            int[] expected = {0, 0, 1, 1, 1, 2, 2};
            DutchNationalFlagSolution.DutchFlagPartition(pivotIndex, A);

            for(int i = 0; i < expected.Length; i++){
                Assert.Equal(expected[i], A[i]);
            }
        }

        [Fact]
        public void CanPartition02()
        {
            int[] A = {0, 1, 2, 0, 2, 1, 1};
            var pivotIndex = 0;

            int[] expected = {0, 0, 2, 2, 1, 1, 1};
            DutchNationalFlagSolution.DutchFlagPartition(pivotIndex, A);

            for(int i = 0; i < expected.Length; i++){
                Assert.Equal(expected[i], A[i]);
            }
        }

        [Fact]
        public void CanPartition03()
        {
            int[] A = {0, 1, 2, 0, 2, 1, 1};
            var pivotIndex = 2;

            int[] expected = {0, 1, 0, 1, 1, 2, 2};
            DutchNationalFlagSolution.DutchFlagPartition(pivotIndex, A);

            for(int i = 0; i < expected.Length; i++){
                Assert.Equal(expected[i], A[i]);
            }
        }          
    }
}
