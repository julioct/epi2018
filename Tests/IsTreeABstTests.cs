using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class IsTreeABstTests
    {
        [Fact]
        public void TreeIsABst()
        {
            var tree = Utilities.BuildBst();

            var expected = true;
            var actual = IsTreeABstSolution.IsTreeABst(tree);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TreeIsNotABst()
        {
            var root = new TreeNode<int>(19);
            root.Left = new TreeNode<int>(7);
            root.Right = new TreeNode<int>(15);
            root.Left.Left = new TreeNode<int>(3);
            root.Left.Right = new TreeNode<int>(11);
            root.Right.Left = new TreeNode<int>(23);
            root.Right.Right = new TreeNode<int>(47);

            var expected = false;
            var actual = IsTreeABstSolution.IsTreeABst(root);
            Assert.Equal(expected, actual);
        }        
    }
}
