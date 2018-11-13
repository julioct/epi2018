using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class EvaluateRpnTests
    {
        [Fact]
        public void CanEvaluateRpn()
        {
            var expression = "3,4,+,2,x,1,+";
            
            var expected = 15;
            var actual = EvaluateRpnSolution.Eval(expression);

            Assert.Equal(expected, actual);
        }
    }
}
