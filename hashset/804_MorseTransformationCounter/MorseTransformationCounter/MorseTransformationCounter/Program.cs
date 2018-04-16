using System;

namespace MorseTransformationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"gin", "zen", "gig", "msg"};

            var solver = new MorseTransformationCounter();

            var transformationCount = solver.CountUniqueMorseTransformations(words);

            Console.WriteLine($"Transformation count is {transformationCount}");
            Console.ReadLine();
        }
    }
}
