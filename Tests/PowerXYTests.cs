using System;
using System.Collections.Generic;
using System.Drawing;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class PowerXYTests
    {
        [Fact]
        public void CanCalculatePowerXY()
        {
            var x = 2;
            var y = 10;

            var expected = 1024;
            var actual = PowerXYSolution.Power(x, y);
            Assert.Equal(expected, actual);
        }
    }
}
