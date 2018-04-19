using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 4;
            var y = 14;

            var solver = new HammingDistanceCounter();

            var count = solver.CountHammingDistance(x, y);

            Console.WriteLine($"Hamming Distance is {count}");
            Console.ReadLine();
        }
    }
}
