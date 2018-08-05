using System.Collections.Generic;

namespace MinStack
{
    internal class MinStack
    {
        private class Node
        {
            public int Item { get; set; }

            public int Min { get; set; }
        }

        private readonly Stack<Node> _stack;

        public MinStack()
        {
            _stack = new Stack<Node>();
        }

        public void Push(int x)
        {
            if (_stack.Count != 0)
            {
                var peek = _stack.Peek();

                if (x >= peek.Min) return;

                foreach (var node in _stack)
                {
                    node.Min = x;
                }
            }

            var newNode = new Node
            {
                Item = x,
                Min = x
            };
            _stack.Push(newNode);
        }

        public void Pop()
        {
            _stack.Pop();
        }

        public int Top()
        {
            return _stack.Count != 0 ? _stack.Peek().Item : 0;
        }

        public int GetMin()
        {
            return _stack.Count != 0 ? _stack.Peek().Min : 0;
        }
    }
}
