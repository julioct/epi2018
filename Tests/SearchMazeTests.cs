using System;
using System.Collections.Generic;
using System.Drawing;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class SearchMazeTests
    {
        [Fact]
        public void PathExists()
        {
            var maze = new bool[3,3] { 
                { false, false, false }, 
                { false, true, true }, 
                { false, false, false }, 
            };

            var start = new Point(2,0);
            var end = new Point(0, 2);

            var expected = new List<Point>();
            expected.Add(start);
            expected.Add(new Point(1,0));
            expected.Add(new Point(0,0));
            expected.Add(new Point(0,1));
            expected.Add(end);

            var path = SearchMazeSolution.SearchMaze(maze, start, end);

            var pathEnd = path[path.Count - 1];
            Assert.Equal(end, pathEnd);
        }

        [Fact]
        public void PathDoesNotExist()
        {
            var maze = new bool[3,3] { 
                { false, true, false }, 
                { false, true, true }, 
                { false, false, false }, 
            };

            var start = new Point(2,0);
            var end = new Point(0, 2);

            var expected = new List<Point>();
            expected.Add(start);
            expected.Add(new Point(1,0));
            expected.Add(new Point(0,0));
            expected.Add(new Point(0,1));
            expected.Add(end);

            var path = SearchMazeSolution.SearchMaze(maze, start, end);

            Assert.Equal(0, path.Count);
        }        
    }
}
