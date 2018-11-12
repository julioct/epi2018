using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class DeleteKthLastFromListSolution
    {
        public static ListNode<int> RemoveKthLast(ListNode<int> L, int k){
            ListNode<int> dummyHead = new ListNode<int>(0);
            dummyHead.Next = L;
            ListNode<int> p1 = dummyHead, p2 = dummyHead.Next;
            
            for (int i = 0; i < k; i++)
            {
                p2 = p2.Next;
            }

            while(p2!= null){
                p1 = p1.Next;
                p2 = p2.Next;
            }

            p1.Next = p1.Next.Next;
            return dummyHead.Next;
        }
    }    
}
