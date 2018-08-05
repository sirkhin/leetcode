namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arrayStack = new ArrayStack<string>();

            arrayStack.Push("first");
            arrayStack.Push("second");
            arrayStack.Push("third");
            arrayStack.Push("forth");
            arrayStack.Pop();
            arrayStack.Pop();
            arrayStack.Pop();

            var linkedListStack = new LinkedListStack<string>();

            linkedListStack.Push("first");
            linkedListStack.Push("second");
            linkedListStack.Push("third");
            linkedListStack.Push("forth");
            linkedListStack.Pop();
            linkedListStack.Pop();
            linkedListStack.Pop();
        }
    }
}
