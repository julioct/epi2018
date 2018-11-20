using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class SortedListsMergeSolution
    {
        public static ListNode<int> MergeTwoSortedLists(ListNode<int> L1, ListNode<int> L2){
            var dummyHead = new ListNode<int>(0);
            var L3 = dummyHead;

            while(L1 != null && L2 != null){
                if (L1.Data < L2.Data){
                    L3.Next = L1;
                    L1 = L1.Next;
                } else {
                    L3.Next = L2;
                    L2 = L2.Next;
                }

                L3 = L3.Next;
            }

            L3.Next = L1 == null ? L2 : L1;
            return dummyHead.Next;
        }
    }    
}
