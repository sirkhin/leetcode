using System;
using System.Linq;

namespace Stack
{
    public class ArrayStack<T> where T: class
    {
        private T[] _array;

        private int _current = 0;

        public ArrayStack()
        {
            _array = new T[1];
        }

        public void Push(T item)
        {
            _array[_current++] = item;

            if (_current == _array.Length)
            {
                IncreaseArraySize();
            }
        }

        private void IncreaseArraySize()
        {
            Array.Resize(ref _array, 2 * _array.Length);
        }

        public T Pop()
        {
            var item = _array[_current - 1];

            _array[_current-- - 1] = null;

            if (_current == _array.Length / 4)
            {
                Array.Resize(ref _array, _array.Length / 2);
            }

            return item;
        }

        public bool IsEmpty()
        {
            return !_array.Any();
        }
    }
}
