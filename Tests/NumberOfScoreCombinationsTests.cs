using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class NumberOfScoreCombinationsTests
    {
        [Fact]
        public void CanComputeNumScoreCombinations()
        {
            var finalScore = 12;
            int[] individualPlayScores = {2, 3, 7};

            var expected = 4;
            var actual = NumberOfScoreCombinationsSolution.NumCombinationsForFinalScore(finalScore, individualPlayScores);

            Assert.Equal(expected, actual);
        }      
    }
}
