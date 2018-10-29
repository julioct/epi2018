using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class SearchFirstGreaterValueInBstTests
    {
        [Fact]
        public void CanFindFirstGreaterValue()
        {
            var tree = Utilities.BuildBst();
            var value = 23;
            
            var expected = 29;
            var actual = SearchFirstGreaterValueInBstSolution.FindFirstGreaterThanK(tree, value);

            Assert.Equal(expected, actual.Data);
        }    
    }
}
