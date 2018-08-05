using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var minStack = new MinStack();

            minStack.Push(5);
            minStack.Push(2);
            minStack.Push(12);
            minStack.Push(1);

            Console.WriteLine(minStack.GetMin());
            minStack.Pop();
            minStack.Pop();
            Console.WriteLine(minStack.GetMin());
            Console.ReadLine();
        }
    }
}
