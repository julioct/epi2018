using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class IntSquareRootSolution
    {
        public static int SquareRoot(int k){
            var left = 0;
            var right = k;

            while(left < right){
                var mid = (left + right) / 2;
                var square = mid * mid;
                if (square > k){
                    right = mid - 1;
                } else if (square <= k){
                    left = mid + 1;
                }
            }

            return left - 1;
        }
    }    
}
