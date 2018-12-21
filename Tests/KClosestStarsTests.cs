using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class KClosestStarsTests
    {
        [Fact]
        public void CanFindClosestKStars()
        {
            var stars = new List<KClosestStarsSolution.Star>();
            stars.Add(new KClosestStarsSolution.Star(1, 1, 1));
            stars.Add(new KClosestStarsSolution.Star(25, 25, 25));
            stars.Add(new KClosestStarsSolution.Star(13, 13, 13));
            stars.Add(new KClosestStarsSolution.Star(99, 99, 99));
            stars.Add(new KClosestStarsSolution.Star(5, 5, 5));
            stars.Add(new KClosestStarsSolution.Star(33, 33, 33));
            stars.Add(new KClosestStarsSolution.Star(51, 51, 51));

            var k = 3;

            var expected = new List<KClosestStarsSolution.Star>();
            expected.Add(stars[2]);
            expected.Add(stars[4]);
            expected.Add(stars[0]);

            var actual = KClosestStarsSolution.FindClosestKStars(k, stars);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}
