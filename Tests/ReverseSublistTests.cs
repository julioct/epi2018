using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class ReverseSublistTests
    {
        [Fact]
        public void CanReverseSubList()
        {
            var list = BuildList(new int[]{11, 7, 5, 3, 2});            
            var s = 2;
            var f = 4;

            var expected = BuildList(new int[]{11, 3, 5, 7, 2});
            var actual = ReverseSublistSolution.ReverseSublist(list, s, f);

            while (actual != null)
            {
                Assert.Equal(expected.Data, actual.Data);
                expected = expected.Next;
                actual = actual.Next;
            }
        }

        [Fact]
        public void CanReverseEntireList()
        {
            var list = BuildList(new int[]{11, 7, 5, 3, 2});            
            var s = 1;
            var f = 5;

            var expected = BuildList(new int[]{2, 3, 5, 7, 11});
            var actual = ReverseSublistSolution.ReverseSublist(list, s, f);

            while (actual != null)
            {
                Assert.Equal(expected.Data, actual.Data);
                expected = expected.Next;
                actual = actual.Next;
            }
        }        

        private ListNode<int> BuildList(int[] elements){
            var dummyHead = new ListNode<int>(-1);
            var current = dummyHead;

            for (int i = 0; i < elements.Length; i++)
            {
                current.Next = new ListNode<int>(elements[i]);
                current = current.Next;
            }

            return dummyHead.Next;
        }
    }
}
