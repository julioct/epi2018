using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class SearchFirstGreaterValueInBstSolution
    {
        public static TreeNode<int> FindFirstGreaterThanK(TreeNode<int> tree, int k){
            TreeNode<int> firstSoFar = null;
            var subtree = tree;

            while(subtree != null){
                if (subtree.Data > k){
                    firstSoFar = subtree;
                    subtree = subtree.Left;
                } else {
                    subtree = subtree.Right;
                }
            }

            return firstSoFar;
        }
    }    
}
