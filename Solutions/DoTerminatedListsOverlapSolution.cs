using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class DoTerminatedListsOverlapSolution
    {
        public static ListNode<int> OverlappingNoCycleLists(ListNode<int> l0, ListNode<int> l1){
            var countL0 = CountNodes(l0);
            var countL1 = CountNodes(l1);
            var diff = Math.Abs(countL0 - countL1);

            if (countL1 > countL0){
                var temp = l0;
                l0 = l1;
                l1 = temp;
            }

            for(int i = 0; i < diff; i++){
                l0 = l0.Next;
            }

            while(l0 != null && l1 != null && l0 != l1){
                l0 = l0.Next;
                l1 = l1.Next;
            }

            return l0;
        }

        private static int CountNodes(ListNode<int> node){
            var count = 0;
            var p = node;

            while(p != null){
                count++;
                p = p.Next;
            }

            return count;
        }
    }    
}
