using System;

namespace JudgeRouteCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            var moves = "LLRRUD";

            var solver = new RouteCircleFinder();

            var isCircle = solver.CheckIfCircleRoute(moves);

            Console.WriteLine($"Is circle? {isCircle}");
            Console.ReadLine();
        }
    }
}
