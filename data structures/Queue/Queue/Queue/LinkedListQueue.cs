namespace Queue
{
    public class LinkedListQueue<T> where T: class
    {
        private class Node<T> where T : class
        {
            public T Item { get; set; }

            public Node<T> Next { get; set; }
        }

        private Node<T> _first = null;
        private Node<T> _last = null;

        public LinkedListQueue()
        {
            
        }

        public void Enqueue(T item)
        {
            var oldLast = _last;
            _last = new Node<T>
            {
                Item = item,
                Next = null
            };

            if (IsEmpty())
            {
                _first = _last;
            }
            else
            {
                oldLast.Next = _last;
            }
        }

        public T Dequeue()
        {
            var item = _first.Item;

            _first = _first.Next;

            if (IsEmpty())
            {
                _last = null;
            }

            return item;
        }

        private bool IsEmpty()
        {
            return _first == null;
        }
    }
}
