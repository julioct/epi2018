using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class IntersectSortedArraysSolution
    {
        public static List<int> IntersectTwoSortedArrays(int[] A, int[] B){
            var result = new List<int>();
            int aIndex = 0, bIndex = 0;

            while(aIndex < A.Length && bIndex < B.Length){
                if (A[aIndex] == B[bIndex]){
                    if (aIndex > 0 && A[aIndex - 1] != A[aIndex]){
                        result.Add(A[aIndex]);
                    }
                    
                    aIndex++;
                    bIndex++;
                } else if (A[aIndex] < B[bIndex]){
                    aIndex++;
                } else {
                    bIndex++;
                }
            }

            return result;
        }
    }    
}
