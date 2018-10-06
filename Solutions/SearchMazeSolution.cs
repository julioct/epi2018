using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace EPI2018.Solutions
{
    public static class SearchMazeSolution
    {
        public static IList<Point> SearchMaze(bool[,] maze, Point start, Point end){
            var path = new List<Point>();
            SearchMaze(maze, start, end, path);
            return path;
        }

        private static bool SearchMaze(bool [,] maze, Point current, Point end, IList<Point> path){
            if (current.X < 0 || current.X > maze.GetLength(0) - 1
                || current.Y < 0 || current.Y > maze.GetLength(1) - 1
                || maze[current.X, current.Y] == true){
                    return false;
            }

            path.Add(current);
            maze[current.X, current.Y] = true;

            if (current.X == end.X && current.Y == end.Y){
                return true;
            }

            if (SearchMaze(maze, new Point(current.X + 1, current.Y), end, path)
                || SearchMaze(maze, new Point(current.X, current.Y + 1), end, path)
                || SearchMaze(maze, new Point(current.X - 1, current.Y), end, path)
                || SearchMaze(maze, new Point(current.X, current.Y - 1), end, path)
                ){
                    return true;
            }

            path.Remove(current);
            return false;
        }
    }
}
