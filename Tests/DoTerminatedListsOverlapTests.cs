using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class DoTerminatedListsOverlapTests
    {
        [Fact]
        public void CanDetectOverlap()
        {
            var l0 = Utilities.BuildList(new int[]{1, 2, 3, 4});
            var l1 = Utilities.BuildList(new int[]{5, 6});
            l1.Next.Next = l0.Next.Next;

            var expected = l0.Next.Next;
            var actual = DoTerminatedListsOverlapSolution.OverlappingNoCycleLists(l0, l1);

            Assert.Equal(expected, actual);
        }
    }
}
