using System;
using System.Collections.Generic;

namespace MinStack
{
    internal class MinStack
    {
        private readonly Stack<int> _stack;

        private int _min = Int32.MaxValue;

        public MinStack()
        {
            _stack = new Stack<int>();
        }

        public void Push(int x)
        {
            if (x <= _min)
            {
                _stack.Push(_min);
                _min = x;
            }
            _stack.Push(x);
        }

        public void Pop()
        {
            if (_min == _stack.Pop()) _min = _stack.Pop();
        }

        public int Top()
        {
            return _stack.Count != 0 ? _stack.Peek() : 0;
        }

        public int GetMin()
        {
            return _stack.Count != 0 ? _min : 0;
        }
    }
}
