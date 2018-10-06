using System;
using System.Text;

namespace EPI2018.Solutions
{
    public static class StringIntegerInterconversionSolution
    {
        public static string IntToString(int num){
            var isNegative = false;

            if (num < 0){
                isNegative = true;
                num *= -1;
            }

            var builder = new StringBuilder();

            while (num > 0){
                builder.Append((char)('0' + num % 10));
                num /= 10;
            }

            if (isNegative){
                builder.Append("-");
            }


            var arr = builder.ToString().ToCharArray();
            Array.Reverse(arr);
            var s = new string(arr);
            return s;
        }
    }
}
