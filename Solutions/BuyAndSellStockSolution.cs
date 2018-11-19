using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class BuyAndSellStockSolution
    {
        public static double ComputeMaxProfix(double[] prices){
            var maxProfit = 0.0;
            var minBuy = double.MaxValue;

            foreach(var price in prices){
                maxProfit = Math.Max(price - minBuy, maxProfit);
                minBuy = Math.Min(price, minBuy);
            }

            return maxProfit;
        }
    }    
}
