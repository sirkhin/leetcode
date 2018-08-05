namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayQueue = new ArrayQueue<string>();

            arrayQueue.Enqueue("1");
            arrayQueue.Enqueue("2");
            arrayQueue.Enqueue("3");
            arrayQueue.Enqueue("4");
            arrayQueue.Enqueue("5");

            arrayQueue.Dequeue();
            arrayQueue.Dequeue();
            arrayQueue.Dequeue();
            arrayQueue.Dequeue();

            var linkedListQueue = new LinkedListQueue<string>();

            linkedListQueue.Enqueue("1");
            linkedListQueue.Enqueue("2");
            linkedListQueue.Enqueue("3");
            linkedListQueue.Enqueue("4");
            linkedListQueue.Enqueue("5");

            linkedListQueue.Dequeue();
            linkedListQueue.Dequeue();
            linkedListQueue.Dequeue();
            linkedListQueue.Dequeue();
        }
    }
}
