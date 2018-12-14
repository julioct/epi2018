using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class SearchShiftedSortedArrayTests
    {
        [Fact]
        public void CanFindSmallestElement01()
        {
            int[] A = {378,478,550,631,103,203,220,234,279,368};

            var expected = 4;
            var actual = SearchShiftedSortedArraySolution.SearchSmallest(A);

            Assert.Equal(expected, actual);
        }      

        [Fact]
        public void CanFindSmallestElement02()
        {
            int[] A = {378,478,550,631,703,203,220,234,279,368};

            var expected = 5;
            var actual = SearchShiftedSortedArraySolution.SearchSmallest(A);

            Assert.Equal(expected, actual);
        }        
    }
}
