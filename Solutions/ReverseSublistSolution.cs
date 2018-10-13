namespace EPI2018.Solutions
{
    public static class ReverseSublistSolution
    {
        public static ListNode<int> ReverseSublist(ListNode<int> L, int start, int finish){
            var dummyHead = new ListNode<int>(0);
            dummyHead.Next = L;
            var startNode = dummyHead;
            var endNode = dummyHead;
            var i = 1;

            while(i < start){
                startNode = startNode.Next;
                endNode = endNode.Next;
                i++;
            }

            while (i <= finish){
                endNode = endNode.Next;
                i++;
            }

            while(startNode.Next != endNode){
                var newNext = startNode.Next.Next;
                startNode.Next.Next = endNode.Next;
                endNode.Next = startNode.Next;
                startNode.Next = newNext;
            }

            return dummyHead.Next;
        }
    }    
}
