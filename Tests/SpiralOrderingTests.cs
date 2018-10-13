using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class SpiralOrderingTests
    {
        [Fact]
        public void CanComputeOddSpiral()
        {
            var matrix = new int[3,3] { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 }, 
            };

            var expected = new List<int>(new int[]{1, 2, 3, 6, 9, 8, 7, 4, 5});
            var actual = SpiralOrderingSolution.GetSpiralOrder(matrix);

            for(int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void CanComputeEvenSpiral()
        {
            var matrix = new int[4,4] { 
                {  1,  2,  3,  4 }, 
                {  5,  6,  7,  8 }, 
                {  9, 10, 11, 12 }, 
                { 13, 14, 15, 16 }
            };

            var expected = new List<int>(new int[]{1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10});
            var actual = SpiralOrderingSolution.GetSpiralOrder(matrix);

            for(int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }        
    }
}
