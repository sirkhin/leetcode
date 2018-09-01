using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        public static bool AnagramsSort(string first, string second)
        {
            return first.OrderBy(s => s).ToString() == second.OrderBy(s => s).ToString();
        }

        public static bool AnagramsHashset(string first, string second)
        {
            var chars = new HashSet<char>();

            foreach (var c in first)
            {
                if (!chars.Contains(c))
                {
                    chars.Add(c);
                }
            }

            return second.All(c => chars.Contains(c));
        }

        static void Main(string[] args)
        {
            var first = "1234567890asdfghjkl";
            var second = "lkjhgfdsa0987654321";

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var anagrams = Program.AnagramsSort(first, second);
            stopWatch.Stop();

            Console.WriteLine(anagrams);
            Console.WriteLine("Elapsed time: " + stopWatch.ElapsedMilliseconds + " ms");

            var stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            var anagrams2 = Program.AnagramsHashset(first, second);
            stopWatch2.Stop();

            Console.WriteLine(anagrams2);
            Console.WriteLine("Elapsed time: " + stopWatch2.ElapsedMilliseconds + " ms");
            Console.ReadLine();
        }
    }
}
