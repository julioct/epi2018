using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class IsStringPalindromicPunctuationSolution
    {
        public static bool IsPalindrome(string s){
            if (string.IsNullOrEmpty(s)){
                return false;
            }

            int start = 0, end = s.Length - 1;

            while(start < end){                
                while (!char.IsLetterOrDigit(s[start]) && start < end){
                    start++;
                }

                while (!char.IsLetterOrDigit(s[end]) && start < end){
                    end--;
                }

                if (char.ToLower(s[start++]) != char.ToLower(s[end--])){
                    return false;
                }
            }

            return true;
        }
    }    
}
