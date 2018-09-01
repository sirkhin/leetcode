using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSpaces
{
    class Program
    {
        public static string ReplaceSpaces(string s)
        {
            var stringBulder = new StringBuilder(s);
            var result = new StringBuilder {Length = 3 * s.Length};

            var j = 0;
            for (int i = 0; i < stringBulder.Length; i++)
            {
                if (stringBulder[i] == ' ')
                {
                    result[j++] = '%';
                    result[j++] = '2';
                    result[j] = '0';
                }
                else
                {
                    result[j] = stringBulder[i];
                }

                j++;
            }

            return result.ToString().Substring(0, j);
        }

        public static string ReplaceWithShift(string s)
        {
            var spaceCount = 0;

            var chars = s.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    spaceCount++;
                }
            }

            var newLength = chars.Length + spaceCount * 2;
            var newChars = new char[newLength];

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (chars[i] == ' ')
                {
                    newChars[newLength - 1] = '0';
                    newChars[newLength - 2] = '2';
                    newChars[newLength - 3] = '%';

                    newLength = newLength - 3;
                }
                else
                {
                    newChars[newLength - 1] = chars[i];
                    newLength--;
                }
            }

            return Convert.ToString(newChars);
        }

        static void Main(string[] args)
        {
            var s = "1 2 3 4 5 6 7 8 9 a b c d g";

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var result = ReplaceSpaces(s);
            stopWatch.Stop();

            Console.WriteLine(result);
            Console.WriteLine("Elapsed time: " + stopWatch.ElapsedMilliseconds + " ms");

            var stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            var result2 = ReplaceWithShift(s);
            stopWatch2.Stop();

            Console.WriteLine(result2);
            Console.WriteLine("Elapsed time: " + stopWatch2.ElapsedMilliseconds + " ms");
            Console.ReadLine();
        }
    }
}
