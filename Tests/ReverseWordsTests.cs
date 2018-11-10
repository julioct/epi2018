using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class ReverseWordTests
    {
        [Fact]
        public void CanReverseWords()
        {
           var s = "Alice likes Bob".ToCharArray();
           var expected = "Bob likes Alice".ToCharArray();
           ReverseWordsSolution.ReverseWords(s);

           for(int i = 0; i < expected.Length; i++){
               Assert.Equal(expected[i], s[i]);
           }
        }
    }
}
