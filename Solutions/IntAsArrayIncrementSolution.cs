using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class IntAsArrayIncrementSolution
    {
        public static int[] PlusOne(int[] A){
            var len = A.Length;
            A[len - 1]++;

            for (int i = len - 1; i > 0 && A[i] == 10; i--)
            {
                A[i] = 0;
                A[i - 1]++;
            }

            if (A[0] == 10){
                int[] newA = new int[len + 1];                
                for (int i = newA.Length - 1; i > 1; i--)
                {
                    newA[i] = A[i - 1];
                }

                newA[1] = 0;
                newA[0] = 1;
                return newA;
            }

            return A;
        }
    }    
}
