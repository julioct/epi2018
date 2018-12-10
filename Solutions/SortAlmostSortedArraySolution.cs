using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class SortAlmostSortedArraySolution
    {
        public static List<int> SortApproximatelySortedData(IEnumerable<int> sequence, int k){
            var sorted = new List<int>();
            var enumerator = sequence.GetEnumerator();
            var comparer = Comparer<int>.Create((a, b) => b.CompareTo(a));
            var minHeap = new PriorityQueue<int>(comparer);

            for (int i = 0; i < k && enumerator.MoveNext(); i++)
            {
                minHeap.Enqueue(enumerator.Current);
            }

            while(enumerator.MoveNext()){
                minHeap.Enqueue(enumerator.Current);
                sorted.Add(minHeap.Dequeue());                
            }

            while(minHeap.Count > 0){
                sorted.Add(minHeap.Dequeue());
            }

            return sorted;
        }
    }    
}
