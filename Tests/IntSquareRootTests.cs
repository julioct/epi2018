using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class IntSquareRootTests
    {
        [Fact]
        public void CanComputeSquareRoot()
        {
            var k = 21;
            var expected = 4;
            var actual = IntSquareRootSolution.SquareRoot(k);

            Assert.Equal(expected, actual);
        }
    }
}
