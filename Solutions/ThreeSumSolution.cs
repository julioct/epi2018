using System;

namespace EPI2018.Solutions
{
    public static class ThreeSumSolution
    {
        public static bool HasThreeSum(int[] A, int target){
            Array.Sort(A);

            // a + b + c = t 
            // a + b = t - c
            foreach (var element in A)
            {
                if (HasTwoSum(A, target - element)){
                    return true;
                }
            }

            return false;
        }

        private static bool HasTwoSum(int[] A, int target){
            int i = 0, j = A.Length - 1;

            while (i <= j)
            {
                if (A[i] + A[j] > target){
                    j--;
                } else if (A[i] + A[j] < target){
                    i++;
                } else {
                    return true;
                }
            }

            return false;
        }
    }
}
