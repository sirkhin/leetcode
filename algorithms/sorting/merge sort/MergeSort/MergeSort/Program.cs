using System;
using System.Collections.Generic;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new List<int>() {1, 2, 3, 4, 5, 6, 4, 4, 4, 4};

            var sorted = MergeSortSolver.Sort(array);

            sorted.ForEach(s => Console.Write(s + " "));
            Console.ReadLine();
        }
    }
}
