using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class TreeFromPreorderInorderSolution
    {
        public static TreeNode<int> BinaryTreeFromPreorderInorder(int[] preorder, int[] inorder){
            var table = new Dictionary<int, int>();

            for (int i = 0; i < inorder.Length; i++)
            {
                table.Add(inorder[i], i);
            }

            var tree = ComputeTree(0, 0, inorder.Length - 1, table, preorder);
            return tree;
        }

        private static TreeNode<int> ComputeTree(int preorderIndex, int inorderStart, int inorderEnd, Dictionary<int, int> inorderTable, int[] preorder){
            if (inorderStart > inorderEnd){
                return null;
            }

            var node = new TreeNode<int>(preorder[preorderIndex]);

            var inorderIndex = inorderTable[node.Data];
            var leftSubtreeSize = inorderIndex - inorderStart;

            node.Left = ComputeTree(preorderIndex + 1, inorderStart, inorderIndex - 1, inorderTable, preorder);
            node.Right = ComputeTree(preorderIndex + 1 + leftSubtreeSize, inorderIndex + 1, inorderEnd, inorderTable, preorder);

            return node;
        }
    }    
}
