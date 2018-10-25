using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class NearestRepeatedEntriesTests
    {
        [Fact]
        public void CanFindNearestRepeatedEntries()
        {
            string[] paragraph = {"All", "work", "and", "no", "play", "makes", "for", "no", "work", "no", "fun", "and", "no", "results"};

            var expected = 2;
            var actual = NearestRepeatedEntriesSolution.FindNearestRepetition(paragraph);

            Assert.Equal(expected, actual);
        }
    }
}
