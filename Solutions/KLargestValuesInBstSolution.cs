using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class KLargestValuesInBstSolution
    {
        public static List<int> FindKLargestInBst(TreeNode<int> tree, int k){
            var results = new List<int>();
            ReverseInOrderTraversal(tree, k, results);
            return results;
        }

        private static void ReverseInOrderTraversal(TreeNode<int> node, int k, List<int> results){
            if (node != null && results.Count < k){
                ReverseInOrderTraversal(node.Right, k, results);
                
                if (results.Count < k){
                    results.Add(node.Data);
                    ReverseInOrderTraversal(node.Left, k, results);
                }                
            }
        }
    }    
}
