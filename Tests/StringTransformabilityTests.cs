using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class StringTransformabilityTests
    {
        [Fact]
        public void CanTransformString()
        {
            var d = new HashSet<string>();
            d.Add("bat");
            d.Add("cot");
            d.Add("dog");
            d.Add("dag");
            d.Add("dot");
            d.Add("cat");

            var start = "cat";
            var end = "dog";

            var expected = 3;
            var actual = StringTransformabilitySolution.TransformString(d, start, end);

            Assert.Equal(expected, actual);
        }      
    }
}
