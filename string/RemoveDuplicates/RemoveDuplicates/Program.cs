using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        public static String RemoveDuplicates(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;

            bool[] chars = new bool[256];

            var stringBuilder = new StringBuilder(s);

            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (chars[stringBuilder[i]])
                {
                    stringBuilder.Remove(i, 1);
                    i--;
                    continue;
                }

                chars[stringBuilder[i]] = true;
            }

            return stringBuilder.ToString();
        }

        public static void RemoveDuplicates(char[] str)
        {
            if (str == null) return;
            int len = str.Length;
            if (len < 2) return;

            int tail = 1;
            
            for (int i = 1; i < len; ++i)
            {
                int j;
                for (j = 0; j < tail; ++j)
                {
                    if (str[i] == str[j]) break;
                }
                if (j == tail)
                {
                    str[tail] = str[i];
                    ++tail;
                    }
                }

                str[tail] = ' ';
            }

        static void Main(string[] args)
        {
            var s = "121212121";

            RemoveDuplicates(s.ToCharArray());

            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
