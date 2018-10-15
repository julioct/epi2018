using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class TreeLevelOrderTests
    {
        [Fact]
        public void CanComputeNodesInDepthOrder()
        {
            var tree = new TreeNode<int>(314);
            tree.Left = new TreeNode<int>(6);
            tree.Right = new TreeNode<int>(6);
            tree.Left.Left = new TreeNode<int>(271);
            tree.Left.Right = new TreeNode<int>(561);
            tree.Right.Left = new TreeNode<int>(2);
            tree.Right.Right = new TreeNode<int>(271);
            tree.Left.Left.Left = new TreeNode<int>(28);
            tree.Left.Left.Right = new TreeNode<int>(0);
            tree.Left.Right.Right = new TreeNode<int>(3);
            tree.Right.Left.Right = new TreeNode<int>(1);
            tree.Right.Right.Right = new TreeNode<int>(28);

            var expected = new List<List<int>>();
            expected.Add(new List<int>{314});
            expected.Add(new List<int>{6,6});
            expected.Add(new List<int>{271,561,2,271});
            expected.Add(new List<int>{28,0,3,1,28});

            var actual = TreeLevelOrderSolution.BinaryTreeDepthOrder(tree);

            for (int i = 0; i < actual.Count; i++)
            {
                for (int j = 0; j < actual[i].Count; j++)
                {
                    Assert.Equal(expected[i][j], actual[i][j]);
                }
            }
        }
    }
}
