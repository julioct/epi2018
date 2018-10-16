using System;

namespace EPI2018.Solutions
{
    public static class LowestCommonAncestorWithParentSolution
    {
        public static TreeNodeWithParent<int> LCA(TreeNodeWithParent<int> node0, TreeNodeWithParent<int> node1){
            var n0Depth = GetDepth(node0);
            var n1Depth = GetDepth(node1);

            if (n1Depth > n0Depth){
                var temp = node0;
                node0 = node1;
                node1 = temp;
            }

            var depthDiff = Math.Abs(n0Depth - n1Depth);

            while(depthDiff-- > 0){
                node0 = node0.Parent;
            }

            while(node0 != node1){
                node0 = node0.Parent;
                node1 = node1.Parent;
            }

            return node0;
        }

        private static int GetDepth(TreeNodeWithParent<int> node){
            var depth = 0;

            while(node.Parent != null){
                node = node.Parent;
                depth++;
            }

            return depth;
        }

        public class TreeNodeWithParent<T>
        {
            public T Data;
            public TreeNodeWithParent<T> Parent;

            public TreeNodeWithParent(T data){
                Data = data;
            }
        }        
    }    
}
