using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class SearchFirstGreaterValueInBstTests
    {
        [Fact]
        public void CanFindFirstGreaterValue()
        {
            var root = new TreeNode<int>(19);
            root.Left = new TreeNode<int>(7);
            root.Right = new TreeNode<int>(43);
            root.Left.Left = new TreeNode<int>(3);
            root.Left.Right = new TreeNode<int>(11);
            root.Right.Left = new TreeNode<int>(23);
            root.Right.Right = new TreeNode<int>(47);
            root.Left.Left.Left = new TreeNode<int>(2);
            root.Left.Left.Right = new TreeNode<int>(5);
            root.Left.Right.Right = new TreeNode<int>(17);
            root.Right.Left.Right = new TreeNode<int>(37);
            root.Right.Right.Right = new TreeNode<int>(53);
            root.Left.Right.Right.Left = new TreeNode<int>(13);
            root.Right.Left.Right.Left = new TreeNode<int>(29);
            root.Right.Left.Right.Right = new TreeNode<int>(41);
            root.Right.Left.Right.Left.Right = new TreeNode<int>(31);

            var value = 23;
            
            var expected = 29;
            var actual = SearchFirstGreaterValueInBstSolution.FindFirstGreaterThanK(root, value);

            Assert.Equal(expected, actual.Data);
        }    
    }
}