using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class KthLargestInArraySolution
    {
        public static int FindKthLargest(int k, int[] A){
            int left = 0, right = A.Length - 1;
            var rand = new Random();
            int kthLargest = int.MaxValue;

            while (left <= right)
            {
                var pivotIdx = rand.Next(left, right);
                var newPivotIdx = PartitionAroundPivot(left, right, pivotIdx, A);

                if (newPivotIdx == k - 1){
                    kthLargest = A[newPivotIdx];
                    break;
                } else if (newPivotIdx > k - 1){
                    right = newPivotIdx - 1;
                } else {
                    left = newPivotIdx + 1;
                }
            }

            return kthLargest;
        }

        private static int PartitionAroundPivot(int left, int right, int pivotIdx, int[] A){
            var pivotValue = A[pivotIdx];
            var newPivotIdx = left;
            A.Swap(pivotIdx, right);

            for (int i = left; i < right; i++)
            {
                if (A[i] > pivotValue){
                    A.Swap(i, newPivotIdx++);
                }
            }

            A.Swap(right, newPivotIdx);
            return newPivotIdx;
        }

        private static void Swap(this int[] array, int a, int b){
            var tmp = array[a];
            array[a] = array[b];
            array[b] = tmp;
        }
    }    
}
