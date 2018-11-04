using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class RefuelingScheduleTests
    {
        [Fact]
        public void CanFindAmpleCity()
        {
            int[] gallons = {50, 20, 5, 30, 25, 10, 10};
            int[] distances = {900, 600, 200, 400, 600, 200, 100};

            var expected = 3;
            var actual = RefuelingScheduleSolution.FindAmpleCity(gallons, distances);

            Assert.Equal(expected, actual);
        }
    }
}
