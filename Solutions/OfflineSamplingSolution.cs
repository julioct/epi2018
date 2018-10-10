using System;

namespace EPI2018.Solutions
{
    public static class OfflineSamplingSolution
    {
        public static void RandomSampling(int k, int[] A){
            var rand = new Random();
            for (int i = 0; i < k; i++)
            {
                var r = rand.Next(i, A.Length - 1);
                var t = A[i];
                A[i] = A[r];
                A[r] = t;
            }
        }
    }
}
