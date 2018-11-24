using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public static class Utilities
    {
        public static ListNode<int> BuildList(int[] values){
            var dummyHead = new ListNode<int>(-1);
            var current = dummyHead;

            for (int i = 0; i < values.Length; i++)
            {
                current.Next = new ListNode<int>(values[i]);
                current = current.Next;
            }

            return dummyHead.Next;
        }

        public static ListNode<int> GetLastNode(ListNode<int> L){
            while (L.Next != null){
                L = L.Next;
            }

            return L;
        }

        public static TreeNode<int> BuildBst(){
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

            return root;            
        }

        public static TreeNode<int> BuildBalancedTree(){
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

            return root;            
        }        
    }
}
