using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] {1, 124, 23, 245, 2, 4, 6, 5670, 7, 3};

            var heap = new BinaryHeap<int>(array.Length);

            foreach (var item in array)
            {
                heap.Insert(item);
            }

            do
            {
                var max = heap.DeleteMax();
                Console.WriteLine(max);
            }
            while (heap.Count() > 0);

            Console.ReadLine();
        }
    }
}
