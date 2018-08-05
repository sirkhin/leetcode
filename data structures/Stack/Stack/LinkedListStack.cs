namespace Stack
{
    class LinkedListStack<T> where T: class
    {
        private class Node<T>
        {
            public T Item { get; set; }

            public Node<T> Next { get; set; }

            public Node()
            {
                
            }
        }

        private Node<T> _first = null;

        public LinkedListStack()
        {
            
        }

        public void Push(T item)
        {
            var oldFirst = _first;

            _first = new Node<T>()
            {
                Item = item,
                Next = oldFirst
            };
        }

        public T Pop()
        {
            var item = _first.Item;

            _first = _first.Next;

            return item;
        }

        public bool IsEmpty()
        {
            return _first == null;
        }


    }
}
