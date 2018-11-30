using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class NumberOfScoreCombinationsSolution
    {
        public static int NumCombinationsForFinalScore(int finalScore, int[] individualPlayScores){
            var combinations = new int[individualPlayScores.Length, finalScore + 1];

            for (int row = 0; row < individualPlayScores.Length; row++){
                combinations[row, 0] = 1;

                for (int col = 1; col <= finalScore; col++){
                    var individualPlayScore = individualPlayScores[row];

                    var withoutThisPlay = row > 0 ? combinations[row - 1, col] : 0;
                    var withThisPlay = col < individualPlayScore ? 0 : combinations[row, col - individualPlayScore];

                    combinations[row, col] = withoutThisPlay + withThisPlay;
                }
            }

            return combinations[individualPlayScores.Length - 1, finalScore];
        }
    }    
}
