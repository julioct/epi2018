using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class ReverseDigitsTests
    {
        [Fact]
        public void CanReversePositiveNumber()
        {
            var number = 42;
            
            var expected = 24;
            var actual = ReverseDigitsSolution.ReverseDigits(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanReverseNegativeNumber()
        {
            var number = -314;
            
            var expected = -413;
            var actual = ReverseDigitsSolution.ReverseDigits(number);

            Assert.Equal(expected, actual);
        }        

        [Fact]
        public void CanReverseMaxInt()
        {
            var number = int.MaxValue; //2147483647
            
            var expected = 7463847412;
            var actual = ReverseDigitsSolution.ReverseDigits(number);

            Assert.Equal(expected, actual);
        }        
    }
}
