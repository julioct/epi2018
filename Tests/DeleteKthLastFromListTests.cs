using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class DeleteKthLastFromListTests
    {
        [Fact]
        public void CanDeleteKthLastElement01()
        {
            var L = Utilities.BuildList(new int[]{1, 2, 3, 4, 5, 6});
            var k = 2;

            var expected = Utilities.BuildList(new int[]{1, 2, 3, 4, 6});
            var actual = DeleteKthLastFromListSolution.RemoveKthLast(L, k);

            while(expected != null){
                Assert.Equal(expected.Data, actual.Data);
                expected = expected.Next;
                actual = actual.Next;
            }
        }

        [Fact]
        public void CanDeleteKthLastElement02()
        {
            var L = Utilities.BuildList(new int[]{1});
            var k = 1;

            //ListNode<int> expected = null;
            var actual = DeleteKthLastFromListSolution.RemoveKthLast(L, k);

            Assert.Null(actual);
        }        
    }
}
