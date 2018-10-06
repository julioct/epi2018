using System;
using System.Collections.Generic;
using System.Drawing;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class HanoiTests
    {
        [Fact]
        public void CanMoveRings()
        {
            var numRings = 3;
            var numPegs = 3;
            var expected = new List<List<int>>();
            expected.Add(new List<int>{0, 1});
            expected.Add(new List<int>{0, 2});
            expected.Add(new List<int>{1, 2});
            expected.Add(new List<int>{0, 1});
            expected.Add(new List<int>{2, 0});
            expected.Add(new List<int>{2, 1});
            expected.Add(new List<int>{0, 1});

            var actual = HanoiSolution.ComputeTowerHanoi(numRings, numPegs);

            Assert.Equal(expected.Count, actual.Count);
            
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.Equal(expected[i][0], actual[i][0]);
                Assert.Equal(expected[i][1], actual[i][1]);
            }
        }
    }
}
