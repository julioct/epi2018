using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class NearestRepeatedEntriesSolution
    {
        public static int FindNearestRepetition(string[] paragraph){
            var map = new Dictionary<string, int>();
            var minDistance = int.MaxValue;
            
            for(var i = 0; i < paragraph.Length; i++){
                var word = paragraph[i];
                if (map.ContainsKey(word)){
                    minDistance = Math.Min(minDistance, i - map[word]);
                }

                map[word] = i;
            }

            return minDistance != int.MaxValue ? minDistance : -1;
        }
    }    
}
