using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class KLargestValuesInBstTests
    {
        [Fact]
        public void CanFindKLargestValuesInBst()
        {
            var tree = Utilities.BuildBst();
            var k = 5;
            
            var expected = new List<int>{53, 47, 43, 41, 37};
            var actual = KLargestValuesInBstSolution.FindKLargestInBst(tree, k);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }    
    }
}
