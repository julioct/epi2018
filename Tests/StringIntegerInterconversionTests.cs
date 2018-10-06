using System;
using System.Collections.Generic;
using System.Drawing;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class StringIntegerInterconversionTests
    {
        [Fact]
        public void CanConvertPositive()
        {
            var num = 314;
            var expected = "314";
            var actual = StringIntegerInterconversionSolution.IntToString(num);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanConvertNegative()
        {
            var num = -314;
            var expected = "-314";
            var actual = StringIntegerInterconversionSolution.IntToString(num);
            Assert.Equal(expected, actual);
        }        
    }
}
