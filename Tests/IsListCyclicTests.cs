using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class IsListCyclicTests
    {
        [Fact]
        public void CanDetectCycle()
        {
            var list = Utilities.BuildList(new int[]{1, 2, 3, 4, 5, 6, 7, 8});
            var lastNode = Utilities.GetLastNode(list);
            var expected = list.Next.Next;
            lastNode.Next = expected;

            var actual = IsListCyclicSolution.DetectCycle(list);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanDetectNoCycle()
        {
            var list = Utilities.BuildList(new int[]{1, 2, 3, 4, 5, 6, 7, 8});
            var actual = IsListCyclicSolution.DetectCycle(list);
            
            Assert.Null(actual);
        }        
    }
}
