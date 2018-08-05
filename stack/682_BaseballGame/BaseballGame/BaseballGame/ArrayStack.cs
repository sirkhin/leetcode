using System;
using System.Linq;

namespace BaseballGame
{
    public class ArrayStack
    {
        private int[] _array;

        private int _current = 0;

        private int _sum = 0;

        public ArrayStack()
        {
            _array = new int[1];
        }

        public void Push(int item)
        {
            _array[_current++] = item;

            _sum += item;

            if (_current == _array.Length)
            {
                IncreaseArraySize();
            }
        }

        private void IncreaseArraySize()
        {
            Array.Resize(ref _array, 2 * _array.Length);
        }

        public int Pop()
        {
            var item = _array[_current - 1];

            _array[_current-- - 1] = 0;

            _sum -= item;

            if (_current == _array.Length / 4)
            {
                Array.Resize(ref _array, _array.Length / 2);
            }

            return item;
        }
        
        public int Sum()
        {
            return _sum;
        }

    }
}
