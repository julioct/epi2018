using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class IsValidSudokuTests
    {
        [Fact]
        public void CanVerifyValidSudoku()
        {
            var matrix = new int[9,9] {
                {5,3,0,0,7,0,0,0,0},
                {6,0,0,1,9,5,0,0,0},
                {0,9,8,0,0,0,0,6,0},
                {8,0,0,0,6,0,0,0,3},
                {4,0,0,8,0,3,0,0,1},
                {7,0,0,0,2,0,0,0,6},
                {0,6,0,0,0,0,2,8,0},
                {0,0,0,4,1,9,0,0,5},
                {0,0,0,0,8,0,0,7,9}
            };

            var expected = true;
            var actual = IsValidSudokuSolution.IsValidSudoku(matrix);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanVerifyInValidSudoku()
        {
            var matrix = new int[9,9] {
                {5,3,0,0,7,0,0,0,0},
                {5,0,0,1,9,5,0,0,0},
                {0,9,8,0,0,0,0,6,0},
                {8,0,0,0,6,0,0,0,3},
                {4,0,0,8,0,3,0,0,1},
                {7,0,0,0,2,0,0,0,6},
                {0,6,0,0,0,0,2,8,0},
                {0,0,0,4,1,9,0,0,5},
                {0,0,0,0,8,0,0,7,9}
            };

            var expected = false;
            var actual = IsValidSudokuSolution.IsValidSudoku(matrix);

            Assert.Equal(expected, actual);
        }        
    }
}
