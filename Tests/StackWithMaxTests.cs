using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class StackWithMaxTests
    {
        [Fact]
        public void StackWithMaxBasicTest()
        {
            var stack = new StackWithMaxSolution();
            stack.Push(3);
            stack.Push(1);
            stack.Push(5);

            var max = stack.Max();
            Assert.Equal(5, max);

            stack.Pop();
            var val = stack.Pop();

            Assert.Equal(1, val);
        }      
    }
}
