using System;
using System.Runtime.InteropServices;

namespace Queue
{
    public class ArrayQueue<T> where T: class
    {
        private T[] _array;

        private int _count;

        private int _currentHead = 0;

        public ArrayQueue()
        {
            _array = new T[1];
        }

        public void Enqueue(T item)
        {
            _array[_count++] = item;

            if (_count == _array.Length)
            {
                var aux = _array;
                _array = new T[_array.Length * 2];
                Array.Copy(aux, _currentHead, _array, 0, _count);
                _currentHead = 0;
            }
        }

        public T Dequeue()
        {
            var item = _array[_currentHead];

            _array[_currentHead++] = default(T);

            _count--;

            if (_count == _array.Length / 4)
            {
                var aux = _array;
                _array = new T[_array.Length / 2];
                Array.Copy(aux, _currentHead, _array, 0, _count);
                _currentHead = 0;
            }

            return item;
        }
    }
}
