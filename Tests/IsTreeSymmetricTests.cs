using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class IsTreeSymmetricTests
    {
        [Fact]
        public void CanVerifySymmetricTree()
        {
            var tree = new TreeNode<int>(314);
            tree.Left = new TreeNode<int>(6);
            tree.Right = new TreeNode<int>(6);
            tree.Left.Right = new TreeNode<int>(2);
            tree.Right.Left = new TreeNode<int>(2);
            tree.Left.Right.Right = new TreeNode<int>(3);
            tree.Right.Left.Left = new TreeNode<int>(3);

            var expected = true;
            var actual = IsTreeSymmetricSolution.IsTreeSymmetric(tree);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanVerifyAsymmetricTree()
        {
            var tree = new TreeNode<int>(314);
            tree.Left = new TreeNode<int>(6);
            tree.Right = new TreeNode<int>(6);
            tree.Left.Right = new TreeNode<int>(2);
            tree.Right.Left = new TreeNode<int>(8);
            tree.Left.Right.Right = new TreeNode<int>(3);
            tree.Right.Left.Left = new TreeNode<int>(3);

            var expected = false;
            var actual = IsTreeSymmetricSolution.IsTreeSymmetric(tree);

            Assert.Equal(expected, actual);
        }        
    }
}
