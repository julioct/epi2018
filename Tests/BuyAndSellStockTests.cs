using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class BuyAndSellStockTests
    {
        [Fact]
        public void CanComputeMaxProfit()
        {
            double[] prices = {350,315,275,295,260,270,290,230,255,250};

            var expected = 30;
            var actual = BuyAndSellStockSolution.ComputeMaxProfix(prices);

            Assert.Equal(expected, actual);
        }      
    }
}
