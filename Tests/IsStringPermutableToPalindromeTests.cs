using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class IsStringPermutableToPalindromeTests
    {
        [Fact]
        public void CanPermuteToPalindrome()
        {
            var s = "edified";

            var expected = true;
            var actual = IsStringPermutableToPalindromeSolution.CanFormPanlindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanNotPermuteToPalindrome()
        {
            var s = "nopalindromes";

            var expected = false;
            var actual = IsStringPermutableToPalindromeSolution.CanFormPanlindrome(s);

            Assert.Equal(expected, actual);
        }        
    }
}
