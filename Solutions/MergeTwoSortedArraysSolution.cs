using System;

namespace EPI2018.Solutions
{
    public static class MergeTwoSortedArraysSolution
    {
        public static void MergeTwoSortedArrays(int[] A, int m, int[] B, int n){
            var i = m - 1;
            var j = n - 1;
            var current = m + n - 1;

            while(i >= 0 && j >= 0){
                if (A[i] > B[j]){
                    A[current--] = A[i--];
                } else {
                    A[current--] = B[j--];
                }
            }

            while(j >= 0){
                A[current--] = B[j--];
            }
        }
    }
}
