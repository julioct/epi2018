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
    }
}
