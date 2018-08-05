using System.Collections;

namespace QueueUsingStacks
{
    internal class StacksQueue
    {
        private readonly Stack _pushStack;

        private readonly Stack _popStack;

        public StacksQueue()
        {
            _pushStack = new Stack();
            _popStack = new Stack();
        }

        public void Push(int x)
        {
            if (_popStack.Count == 0)
            {
                _pushStack.Push(x);
            }
            else
            {
                while (_popStack.Count != 0)
                {
                    _pushStack.Push(_popStack.Pop());
                }

                _pushStack.Push(x);
            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (_popStack.Count != 0)
            {
                var item = _popStack.Pop();
                return (int) item;
            }
            else
            {
                PushAllToPopStack();

                var item = _popStack.Pop();
                return (int) item;
            }
        }

        /** Get the front element. */
        public int Peek()
        {
            if (_popStack.Count != 0) return (int) _popStack.Peek();

            PushAllToPopStack();

            return (int) _popStack.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return _pushStack.Count == 0 && _popStack.Count == 0;
        }

        private void PushAllToPopStack()
        {
            while (_pushStack.Count != 0)
            {
                _popStack.Push(_pushStack.Pop());
            }
        }
    }
}
