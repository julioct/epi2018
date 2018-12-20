using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class LowestCommonAncestorInBstTests
    {
        [Fact]
        public void CanFindLca()
        {
            var tree = Utilities.BuildBst();
            var n1 = new TreeNode<int>(3);
            var n2 = new TreeNode<int>(17);

            var expected = new TreeNode<int>(7);
            var actual = LowestCommonAncestorInBstSolution.FindLca(tree, n1, n2);
            
            Assert.Equal(expected.Data, actual.Data);
        }      
    }
}
