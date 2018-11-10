using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class ReverseWordsSolution
    {
        public static void ReverseWords(char[] s){
            Reverse(s, 0, s.Length - 1);

            int start = 0, end = 0;

            while(end < s.Length){
                while(end < s.Length && s[end] != ' '){
                    end++;
                }

                Reverse(s, start, end - 1);
                start = end + 1;
                end = start;
            }
        }

        private static void Reverse(char[] s, int start, int end){
            while (start < end){
                var temp = s[start];
                s[start++] = s[end];
                s[end--] = temp;
            }
        }
    }    
}
