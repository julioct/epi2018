using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class StringTransformabilitySolution
    {
        public static int TransformString(HashSet<string> D, string s, string t){
            var visited = new HashSet<string>(D);
            var q = new Queue<StringWithDistance>();

            visited.Remove(s);
            q.Enqueue(new StringWithDistance(s, 0));

            while(q.Count > 0){
                var dequeued = q.Dequeue();

                if (dequeued.CandidateString.Equals(t)){
                    return dequeued.Distance;
                }

                var str = dequeued.CandidateString;

                for (int i = 0; i < str.Length; i++)
                {
                    var strStart = i == 0 ? "" : str.Substring(0, i);
                    var strEnd = i + 1 == str.Length ? "" : str.Substring(i + 1);

                    for (int c = 0; c < 26; c++)
                    {
                        var midChar = (char)('a' + c);
                        var modString = strStart + midChar + strEnd;

                        if (visited.Contains(modString)){
                            visited.Remove(modString);
                            q.Enqueue(new StringWithDistance(modString, dequeued.Distance + 1));
                        }
                    }
                }
            }

            return -1;
        }

        private class StringWithDistance{
            public string CandidateString;
            public int Distance;

            public StringWithDistance(string candidateString, int distance){
                CandidateString = candidateString;
                Distance = distance;
            }
        }        
    }    
}
