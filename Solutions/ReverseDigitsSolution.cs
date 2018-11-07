using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class ReverseDigitsSolution
    {
        public static long Reverse(int x){
            long reverse = 0;

            while(x != 0){
                reverse = reverse * 10 + x % 10;
                x /= 10;
            }

            return reverse;
        }
    }    
}
