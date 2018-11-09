using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class IsValidSudokuSolution
    {
        public static bool IsValidSudoku(int[,] partialAssignment){
            var len = partialAssignment.GetLength(0);

            // Check rows
            for(int i = 0; i < len; i++){
                if (HasDuplicates(i, i + 1, 0, len, partialAssignment)){
                    return false;
                }
            }

            // Check columns
            for(int i = 0; i < len; i++){
                if (HasDuplicates(0, len, i, i + 1, partialAssignment)){
                    return false;
                }
            }

            // Check regions
            var regionSize = (int)Math.Sqrt(len);
            for(int i = 0; i < regionSize; i++){
                for(int j = 0; j < regionSize; j++){
                    var startRow = i * regionSize;
                    var startCol = j * regionSize;
                    if (HasDuplicates(startRow, startRow + 3, startCol, startCol + 3, partialAssignment)){
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool HasDuplicates(int rowStart, int rowEnd, int colStart, int colEnd, int[,] partialAssignment){
            var isPresent = new bool[partialAssignment.GetLength(0) + 1];

            for(int row = rowStart; row < rowEnd; row++){
                for (int col = colStart; col < colEnd; col++){
                    if (partialAssignment[row, col] != 0){
                        if (isPresent[partialAssignment[row, col]]){
                            return true;
                        }

                        isPresent[partialAssignment[row, col]] = true;
                    }
                }
            }

            return false;
        }
    }        
}
