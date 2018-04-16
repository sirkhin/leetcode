using System;

namespace _771_IntersectionFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string j = "Aab";
            string s = "AAaacccCCBB";

            var solver = new IntersectionCounter();

            var intersectionCount = solver.CountIntersections(j, s);

            Console.WriteLine($"Number of intersections is {intersectionCount}");
            Console.ReadLine();
        }
    }
}
