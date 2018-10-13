using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class OfflineSamplingTests
    {
        [Fact]
        public void CanRandomSample()
        {
            int[] originalArray = {3, 7, 5, 11};
            var k = 3;
            var A = originalArray.Clone() as int[];

            OfflineSamplingSolution.RandomSampling(k, A);

            foreach (var element in originalArray)
            {
                Assert.Contains(element, A);
            }
        }      
    }
}
