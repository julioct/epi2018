using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class IntAsArrayIncrementTests
    {
        [Fact]
        public void CanIncrementInteger01()
        {
            int[] A = {1, 2, 9};

            int[] expected = {1, 3, 0};
            var actual = IntAsArrayIncrementSolution.PlusOne(A);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void CanIncrementInteger02()
        {
            int[] A = {1, 2, 8};

            int[] expected = {1, 2, 9};
            var actual = IntAsArrayIncrementSolution.PlusOne(A);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }  

        [Fact]
        public void CanIncrementInteger03()
        {
            int[] A = {9, 9, 9};

            int[] expected = {1, 0, 0, 0};
            var actual = IntAsArrayIncrementSolution.PlusOne(A);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }              
    }
}
