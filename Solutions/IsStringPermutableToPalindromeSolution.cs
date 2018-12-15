using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class IsStringPermutableToPalindromeSolution
    {
        public static bool CanFormPanlindrome(string s){
            var set = new HashSet<char>();

            for(var i = 0; i < s.Length; i++){
                var c = s[i];

                if (!set.Contains(c)){
                    // Odd
                    set.Add(c);
                } else {
                    // Even (remove so we only keep odds)
                    set.Remove(c);
                }
            }

            return set.Count <= 1;
        }
    }    
}
