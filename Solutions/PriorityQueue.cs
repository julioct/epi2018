using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EPI2018.Solutions
{
    public class PriorityQueue<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 0;
        private const int GrowFactor = 2;
        private const int MinGrow = 1;

        private int _capacity = InitialCapacity;
        private T[] _heap = new T[InitialCapacity];
        private int _tail = 0;

        public int Count { get { return _tail; } }
        public int Capacity { get { return _capacity; } }

        protected IComparer<T> Comparer { get; private set; }        

        public PriorityQueue() : this(Comparer<T>.Default)
        {
        }

        public PriorityQueue(Comparer<T> comparer) : this(Enumerable.Empty<T>(), comparer)
        {
        }

        public PriorityQueue(IEnumerable<T> collection)
            : this(collection, Comparer<T>.Default)
        {
        }

        public PriorityQueue(IEnumerable<T> collection, Comparer<T> comparer)
        {
            if (collection == null) throw new ArgumentNullException("collection");
            if (comparer == null) throw new ArgumentNullException("comparer");

            Comparer = comparer;

            foreach (var item in collection)
            {
                if (Count == Capacity)
                    Grow();

                _heap[_tail++] = item;
            }

            for (int i = Parent(_tail - 1); i >= 0; i--)
                BubbleDown(i);
        }

        public void Enqueue(T item)
        {
            if (Count == Capacity)
                Grow();

            _heap[_tail++] = item;
            BubbleUp(_tail - 1);
        }

        public T Peek()
        {
            if (Count == 0) throw new InvalidOperationException("Heap is empty");
            return _heap[0];
        }

        public T Dequeue()
        {
            if (Count == 0) throw new InvalidOperationException("Heap is empty");
            T ret = _heap[0];
            _tail--;
            Swap(_tail, 0);
            BubbleDown(0);
            return ret;
        }        

        public IEnumerator<T> GetEnumerator()
        {
            return _heap.Take(Count).GetEnumerator();
        }        

        private void BubbleUp(int i)
        {
            if (i == 0 || Dominates(_heap[Parent(i)], _heap[i])) 
                return; //correct domination (or root)

            Swap(i, Parent(i));
            BubbleUp(Parent(i));
        }

        private void BubbleDown(int i)
        {
            int dominatingNode = Dominating(i);
            if (dominatingNode == i) return;
            Swap(i, dominatingNode);
            BubbleDown(dominatingNode);
        }

        private int Dominating(int i)
        {
            int dominatingNode = i;
            dominatingNode = GetDominating(YoungChild(i), dominatingNode);
            dominatingNode = GetDominating(OldChild(i), dominatingNode);

            return dominatingNode;
        }

        private int GetDominating(int newNode, int dominatingNode)
        {
            if (newNode < _tail && !Dominates(_heap[dominatingNode], _heap[newNode]))
                return newNode;
            else
                return dominatingNode;
        }

        private bool Dominates(T x, T y){
            return Comparer.Compare(x, y) >= 0;
        }        

        private void Swap(int i, int j)
        {
            T tmp = _heap[i];
            _heap[i] = _heap[j];
            _heap[j] = tmp;
        }

        private static int Parent(int i)
        {
            return (i + 1)/2 - 1;
        }

        private static int YoungChild(int i)
        {
            return (i + 1)*2 - 1;
        }

        private static int OldChild(int i)
        {
            return YoungChild(i) + 1;
        }

        private void Grow()
        {
            int newCapacity = _capacity*GrowFactor + MinGrow;
            var newHeap = new T[newCapacity];
            Array.Copy(_heap, newHeap, _capacity);
            _heap = newHeap;
            _capacity = newCapacity;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}