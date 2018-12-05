using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class IsTreeSymmetricSolution
    {
        public static bool IsTreeSymmetric(TreeNode<int> tree){
            return CheckSymmetric(tree.Left, tree.Right);
        }

        private static bool CheckSymmetric(TreeNode<int> tree1, TreeNode<int> tree2){
            if (tree1 == null && tree2 == null){
                return true;
            }

            return tree1 != null 
                && tree2 != null 
                && tree1.Data == tree2.Data 
                && CheckSymmetric(tree1.Left, tree2.Right) 
                && CheckSymmetric(tree1.Right, tree2.Left);
        }
    }    
}
