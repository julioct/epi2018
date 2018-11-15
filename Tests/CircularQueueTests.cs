using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class CircularQueueTests
    {
        [Fact]
        public void CircularQueueBasicTest()
        {
            var queue = new CircularQueueSolution(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            
            var expected = 1;
            var actual = queue.Dequeue();
            Assert.Equal(expected, actual);

            queue.Enqueue(4);
            queue.Enqueue(5);

            expected = 4;
            actual = queue.Size();
            Assert.Equal(expected, actual);

            queue.Enqueue(6);
            queue.Enqueue(7);

            expected = 6;
            actual = queue.Size();
            Assert.Equal(expected, actual);
        }      
    }
}
