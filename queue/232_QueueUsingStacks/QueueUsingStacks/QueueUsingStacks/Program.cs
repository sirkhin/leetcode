using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var stacksQueue = new StacksQueue();

            stacksQueue.Push(1);
            stacksQueue.Push(2);
            stacksQueue.Push(3);
            stacksQueue.Push(4);

            Console.WriteLine(stacksQueue.Pop());
            Console.WriteLine(stacksQueue.Peek());
            Console.WriteLine(stacksQueue.Empty());

            Console.ReadLine();
        }
    }
}
