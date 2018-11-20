using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class SortedListsMergeTests
    {
        [Fact]
        public void CanMergeLists()
        {
            var L1 = Utilities.BuildList(new int[]{2, 5, 7});
            var L2 = Utilities.BuildList(new int[]{3, 11});

            var expected = Utilities.BuildList(new int[]{2, 3, 5, 7, 11});
            var actual = SortedListsMergeSolution.MergeTwoSortedLists(L1, L2);

            while(expected != null){
                Assert.Equal(expected.Data, actual.Data);
                expected = expected.Next;
                actual = actual.Next;
            }
        }      
    }
}
