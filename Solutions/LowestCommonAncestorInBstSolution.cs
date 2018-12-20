using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class LowestCommonAncestorInBstSolution
    {
        public static TreeNode<int> FindLca(TreeNode<int> tree, TreeNode<int> s, TreeNode<int> b){
            if (s.Data > b.Data){
                var t = s;
                s = b;
                b = t;
            }

            while(tree.Data < s.Data || tree.Data > b.Data){
                while(tree.Data < s.Data){
                    tree = tree.Right;
                }

                while(tree.Data > b.Data){
                    tree = tree.Left;
                }
            }

            return tree;          
        }
    }    
}
