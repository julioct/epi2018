namespace EPI2018.Solutions
{
    public static class IsListCyclicSolution
    {
        public static ListNode<int> DetectCycle(ListNode<int> head){
            ListNode<int> slow = head, fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast){
                    break;
                }
            }

            if (fast == null){
                return null;
            }

            var cycleLen = 0;

            do{
                fast = fast.Next;
                cycleLen++;
            }while( fast != slow);

            slow = fast = head;

            while (cycleLen-- > 0)
            {
                fast = fast.Next;
            }

            while (fast != slow)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return fast;
        }
    }
}
