using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class TreeFromPreorderInorderTests
    {
        [Fact]
        public void CanBuildTreeFromPreorderInorderTests()
        {
            int[] inorder = {2, 3, 5, 7, 11, 17, 13, 19, 23, 29, 31, 37, 41, 43, 47, 53};
            int[] preorder = {19, 7, 3, 2, 5, 11, 17, 13, 43, 23, 37, 29, 31, 41, 47, 53};

            var expected = Utilities.BuildBst();
            var actual = TreeFromPreorderInorderSolution.BinaryTreeFromPreorderInorder(preorder, inorder);

            AssertTrees(expected, actual);            
        }   

        private void AssertTrees(TreeNode<int> expected, TreeNode<int> actual){
            if (expected == null || actual == null){
                return;
            }            

            AssertTrees(expected.Left, actual.Left);
            Assert.Equal(expected.Data, actual.Data);
            AssertTrees(expected.Right, actual.Right);
        }
    }
}
