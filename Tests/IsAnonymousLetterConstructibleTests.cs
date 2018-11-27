using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class IsAnonymousLetterConstructibleTests
    {
        [Fact]
        public void CanConstructAnonymousLetter()
        {
            var letter = "the letter";
            var magazine = "let the letter be";

            var expected = true;
            var actual = IsAnonymousLetterConstructibleSolution.IsLetterConstructibleFromMagazine(letter, magazine);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanNotConstructAnonymousLetter()
        {
            var letter = "the letter";
            var magazine = "my letter";

            var expected = false;
            var actual = IsAnonymousLetterConstructibleSolution.IsLetterConstructibleFromMagazine(letter, magazine);

            Assert.Equal(expected, actual);
        }          
    }
}
