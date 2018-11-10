using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class IsStringPalindromicPunctuationTests
    {
        [Fact]
        public void EvenStringIsPalindrome()
        {
            var s = "abba";
            var expected = true;
            var actual = IsStringPalindromicPunctuationSolution.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OddStringIsPalindrome()
        {
            var s = "abcba";
            var expected = true;
            var actual = IsStringPalindromicPunctuationSolution.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }        

        [Fact]
        public void StringWithPunctuationIsPalindrome()
        {
            var s = "A man, a plan, a canal, Panama";
            var expected = true;
            var actual = IsStringPalindromicPunctuationSolution.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StringIsNotPalindrome()
        {
            var s = "Ray a Ray";
            var expected = false;
            var actual = IsStringPalindromicPunctuationSolution.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }        
    }
}
