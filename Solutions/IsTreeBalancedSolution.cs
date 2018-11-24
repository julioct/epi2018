using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class IsTreeBalancedSolution
    {
        public static bool IsBalanced(TreeNode<int> root){
            var result = CheckBalanced(root);
            return result.IsBalanced;
        }

        private static ElementWithHeight CheckBalanced(TreeNode<int> node){
            if (node == null){
                return new ElementWithHeight(true, -1);
            }

            var leftElement = CheckBalanced(node.Left);

            if (!leftElement.IsBalanced){
                return leftElement;
            }

            var rightElement = CheckBalanced(node.Right);

            if (!rightElement.IsBalanced){
                return rightElement;
            }

            var height = Math.Max(leftElement.Height, rightElement.Height) + 1;
            var isBalanced = Math.Abs(leftElement.Height - rightElement.Height) <= 1;

            return new ElementWithHeight(isBalanced, height);
        }

        private class ElementWithHeight{
            public bool IsBalanced;
            public int Height;

            public ElementWithHeight(bool isBalanced, int height){
                IsBalanced = isBalanced;
                Height = height;
            }
        }
    }    
}
