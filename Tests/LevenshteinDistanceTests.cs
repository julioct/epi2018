using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class LevenshteinDistanceTests
    {
        [Fact]
        public void CanComputeLevenshteinDistance1()
        {
            var A = "Saturday";
            var B = "Sundays";

            var expected = 4;
            var actual = LevenshteinDistanceSolution.LevenshteinDistance(A, B);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanComputeLevenshteinDistance2()
        {
            var A = "Carthorse";
            var B = "Orchestra";

            var expected = 8;
            var actual = LevenshteinDistanceSolution.LevenshteinDistance(A, B);

            Assert.Equal(expected, actual);
        }
    }
}
