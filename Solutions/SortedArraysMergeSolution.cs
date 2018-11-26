using System;
using System.Collections.Generic;
using System.Linq;

namespace EPI2018.Solutions
{
    public static class SortedArraysMergeSolution
    {
        public static List<int> MergeSortedArrays(int[][] sortedArrays){
            var elementIndexes = new int[sortedArrays.Length];

            // a.Value.CompareTo(b.Value) -> sorts in descending order (max heap)
            // b.Value.CompareTo(a.Value) -> sorts in ascending order (min heap)
            var comparer = Comparer<ArrayEntry>.Create((a, b) => b.Value.CompareTo(a.Value));
            var minHeap = new PriorityQueue<ArrayEntry>(comparer);

            // Initialize queue with first elements from each array
            for(int arrayIndex = 0; arrayIndex < sortedArrays.Length; arrayIndex++)
            {                
                var elementIndex = elementIndexes[arrayIndex]++;
                if (elementIndex < sortedArrays[arrayIndex].Length){
                    minHeap.Enqueue(new ArrayEntry(arrayIndex, sortedArrays[arrayIndex][elementIndex]));
                }                
            }

            var merged = new List<int>();

            // Always keep at most sortedArrays.Length elements in the queue
            while(minHeap.Count > 0){
                var entry = minHeap.Dequeue();
                var elementIndex = elementIndexes[entry.ArrayId]++;
                if (elementIndex < sortedArrays[entry.ArrayId].Length){
                    minHeap.Enqueue(new ArrayEntry(entry.ArrayId, sortedArrays[entry.ArrayId][elementIndex]));
                }                
                merged.Add(entry.Value);
            }

            return merged;
        }

        private class ArrayEntry {
            public int ArrayId;
            public int Value;

            public ArrayEntry(int arrayId, int value){
                ArrayId = arrayId;
                Value = value;
            }
        }
    }    
}
