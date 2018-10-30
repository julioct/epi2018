using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class NQueensSolution
    {
        public static List<List<int>> NQueens(int n){
            var results = new List<List<int>>();
            SolveNQueens(0, n, new List<int>(), results);
            return results;
        }

        private static void SolveNQueens(int row, int n, List<int> colPlacements, List<List<int>> results){
            if (row == n){
                results.Add(new List<int>(colPlacements));
                return;
            }

            for(var col = 0; col < n; col++){
                colPlacements.Add(col);
                if (IsValid(colPlacements)){
                    SolveNQueens(row + 1, n, colPlacements, results);
                }
                colPlacements.RemoveAt(colPlacements.Count - 1);
            }
        }

        private static bool IsValid(List<int> colPlacements){
            var currentRow = colPlacements.Count - 1;

            for(var row = 0; row < currentRow; row++){
                var columnDiff = Math.Abs(colPlacements[row] - colPlacements[currentRow]);
                var rowDiff = currentRow - row;

                if(columnDiff == 0 || columnDiff == rowDiff){
                    return false;
                }
            }

            return true;
        }
    }    
}
