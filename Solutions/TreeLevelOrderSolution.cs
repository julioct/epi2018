using System.Collections.Generic;
using System.Linq;

namespace EPI2018.Solutions
{
    public static class TreeLevelOrderSolution
    {
        public static List<List<int>> BinaryTreeDepthOrder(TreeNode<int> tree){
            var result = new List<List<int>>();

            if (tree == null){
                return result;
            }

            var currList = new List<TreeNode<int>>();
            currList.Add(tree);

            while(currList.Count != 0){
                result.Add(currList.Select(e => e.Data).ToList());
                var parentsList = currList;
                currList = new List<TreeNode<int>>();

                foreach (var element in parentsList)
                {
                    if (element.Left != null){
                        currList.Add(element.Left);
                    }

                    if (element.Right != null){
                        currList.Add(element.Right);
                    }
                }
            }
            
            return result;
        }
    }    
}
