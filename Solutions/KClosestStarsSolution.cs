using System;
using System.Collections.Generic;
using System.Linq;

namespace EPI2018.Solutions
{
    public static class KClosestStarsSolution
    {        
        public static List<Star> FindClosestKStars(int k, IEnumerable<Star> stars){
            var comparer = Comparer<Star>.Create((a, b) => a.CompareTo(b));
            var maxHeap = new PriorityQueue<Star>(comparer);

            foreach (var star in stars)
            {
                maxHeap.Enqueue(star);

                if (maxHeap.Count > k){
                    maxHeap.Dequeue();
                }
            }

            return maxHeap.ToList();
        }

        public class Star : IComparable<Star>{
            public int X;
            public int Y;
            public int Z;

            public Star(int x, int y, int z){
                X = x;
                Y = y;
                Z = z;
            }

            public double Distance {
                get {
                    return Math.Sqrt(X*X + Y*Y + Z*Z);
                }
            }

            public int CompareTo(Star other)
            {
                return this.Distance.CompareTo(other.Distance);
            }
        }
    }    
}
