using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class IsTreeBalancedTests
    {
        [Fact]
        public void CanVerifyTreeIsBalanced()
        {
            var tree = Utilities.BuildBalancedTree();

            var expected = true;
            var actual = IsTreeBalancedSolution.IsBalanced(tree);

            Assert.Equal(expected, actual);
        }      

        [Fact]
        public void CanVerifyTreeIsNotBalanced()
        {
            var tree = Utilities.BuildBst();

            var expected = false;
            var actual = IsTreeBalancedSolution.IsBalanced(tree);

            Assert.Equal(expected, actual);
        }        
    }
}
