using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class LevenshteinDistanceSolution
    {
        public static int LevenshteinDistance(string A, string B){
            int[,] matrix = new int[A.Length, B.Length];

            for(var row = 0; row < matrix.GetLength(0); row++){
                for(var col = 0; col < matrix.GetLength(1); col++){
                    matrix[row, col] = -1;
                }
            }

            return ComputeEdits(A, A.Length - 1, B, B.Length - 1, matrix);
        }

        private static int ComputeEdits(string A, int A_idx, string B, int B_idx, int[,] matrix){
            if (A_idx < 0){
                return B_idx + 1;
            } else if (B_idx < 0){
                return A_idx + 1;
            }

            if (matrix[A_idx, B_idx] == -1){
                if (A[A_idx] == B[B_idx]){
                    matrix[A_idx, B_idx] = ComputeEdits(A, A_idx - 1, B, B_idx - 1, matrix);
                } else {
                    var diag = ComputeEdits(A, A_idx - 1, B, B_idx - 1, matrix);
                    var top = ComputeEdits(A, A_idx, B, B_idx - 1, matrix);
                    var left = ComputeEdits(A, A_idx - 1, B, B_idx, matrix);
                    matrix[A_idx, B_idx] = 1 + Math.Min(diag, Math.Min(top, left));
                }
            }

            return matrix[A_idx, B_idx];
        }
    }    
}
