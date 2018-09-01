using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 124, 23, 245, 2, 4, 6, 5670, 7, 3 };

            Heap.Sort(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
