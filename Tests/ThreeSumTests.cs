using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class ThreeSumTests
    {
        [Fact]
        public void ThreeSumExists()
        {
            int[] nums = {11, 2, 5, 7, 3};
            var target = 21;
            var expected = true;
            var actual = ThreeSumSolution.HasThreeSum(nums, target);
            Assert.Equal(expected, actual);
        }   

        [Fact]
        public void ThreeSumDoesNotExist()
        {
            int[] nums = {11, 2, 5, 7, 3};
            var target = 22;
            var expected = false;
            var actual = ThreeSumSolution.HasThreeSum(nums, target);
            Assert.Equal(expected, actual);
        }        
    }
}
