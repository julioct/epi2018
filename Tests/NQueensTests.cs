using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class NQueensTests
    {
        [Fact]
        public void CanCalculateNQueens()
        {
            var n = 4;

            var expected = new List<List<int>>();
            expected.Add(new List<int>{1,3,0,2});
            expected.Add(new List<int>{2,0,3,1});

            var actual = NQueensSolution.NQueens(n);

            for (int placement = 0; placement < expected.Count; placement++)
            {
                for (int column = 0; column < n; column++){
                    Assert.Equal(expected[placement][column], actual[placement][column]);
                }
            }
        }
    }
}
