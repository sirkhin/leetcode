using System;

namespace BinaryHeap
{
    /*
        A binary heap is defined as a binary tree with two additional constraints:[3]

            1) Shape property: a binary heap is a complete binary tree; that is, all levels of the tree, 
                except possibly the last one (deepest) are fully filled, and, if the last level of the tree is not complete, 
                the nodes of that level are filled from left to right.
            2) Heap propery: the key stored in each node is either greater than or equal to (≥) or less than or equal to (≤) 
                the keys in the node's children, according to some total order.
     */
    public class BinaryHeap<T> where T: IComparable
    {
        private readonly T[] _heapArray;

        private readonly int _count;

        private int _current;

        public BinaryHeap(int count)
        {
            _heapArray = new T[count + 1];
            _count = count;
        }

        public void Insert(T item)
        {
            _heapArray[++_current] = item;
            Swim(_current);
        }

        public T DeleteMax()
        {
            var max = _heapArray[1];

            Exchange(1, _current--);
            Sink(1);
            _heapArray[_current + 1] = default(T);

            return max;
        }

        public int Count()
        {
            return _current;
        }

        private void Swim(int index)
        {
            while (index > 1 && _heapArray[index / 2].CompareTo(_heapArray[index]) < 0) //if bigger than parent than need to swap
            {
                Exchange(index, index / 2);
                index /= 2;
            }
        }

        private void Sink(int index)
        {
            while (2 * index < _current) //_current is the end of array
            {
                var j = 2 * index; //first child index

                if (j < _count && _heapArray[j].CompareTo(_heapArray[j + 1]) < 0) //try to determine which child is bigger
                {
                    j++;
                }
                if (_heapArray[index].CompareTo(_heapArray[j]) >= 0) continue;

                Exchange(index, j);
                index = j;
            }
        }

        private void Exchange(int firstIndex, int secondIndex)
        {
            var temp = _heapArray[firstIndex];
            _heapArray[firstIndex] = _heapArray[secondIndex];
            _heapArray[secondIndex] = temp;
        }
    }
}
