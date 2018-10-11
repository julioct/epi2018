using System;
using System.Collections.Generic;
using System.Drawing;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class SearchFirstKeyTests
    {
        [Fact]
        public void CanFindFirstIndexOfK()
        {
            int[] candidates = {-14, -10, 2, 108, 108, 243, 285, 285, 285, 401};
            var k = 285;

            var expected = 6;
            var actual = SearchFirstKeySolution.SearchFirstOfK(candidates, k);
            Assert.Equal(expected, actual);
        }
    }
}
