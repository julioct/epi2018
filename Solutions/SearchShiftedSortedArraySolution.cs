using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class SearchShiftedSortedArraySolution
    {
        public static int SearchSmallest(int[] A){
            int start = 0, end = A.Length - 1;
            
            while(start < end){
                var mid = (end - start)/2 + start;

                if(A[mid] > A[end]){
                    start = mid + 1;
                } else {
                    end = mid;
                }
            }

            return start;
        }
    }    
}
