using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharacters
{
    class Program
    {
        public static bool HasUniqueCharacters(string s)
        {
            HashSet<char> chars = new HashSet<char>();

            foreach (char t in s)
            {
                if (chars.Contains(t))
                {
                    return false;
                }

                chars.Add(t);
            }

            return true;
        }

        public static bool HasUniqueCharactersImproved(string s)
        {
            bool[] chars = new bool[256];

            foreach (char t in s)
            {
                if (chars[t])
                {
                    return false;
                }

                chars[t] = true;
            }

            return true;
        }

        static void Main(string[] args)
        {
            var s = "zxcvbnm,./asdfghjkl;'qwertyuiop[]a";

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var result = Program.HasUniqueCharacters(s);
            stopwatch.Stop();
            Console.WriteLine(result);
            Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds + " ms");

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            var result2 = Program.HasUniqueCharacters(s);
            stopwatch2.Stop();
            Console.WriteLine(result2);
            Console.WriteLine("Elapsed time: " + stopwatch2.ElapsedMilliseconds + " ms");

            Console.ReadLine();
        }
    }
}
