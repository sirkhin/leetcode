using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeString
{
    class Program
    {
        public string DecodeString(string s)
        {
            var stack = new Stack<string>();
            var builder = new StringBuilder();
            var buffer = new StringBuilder();
            var multiplier = new StringBuilder();
            var number = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ']')
                {
                    stack.Push(s[i].ToString());
                }
                else if (s[i] == '[')
                {
                    continue;
                }
                else if (int.TryParse(s[i].ToString(), out number))
                {
                    var temp = 0;

                    if (i == 0 || !int.TryParse(s[i - 1].ToString(), out temp))
                    {
                        multiplier.Append(number);

                        while (stack.Count > 0 && stack.Peek() != "]")
                        {
                            var item = stack.Pop();

                            if (int.TryParse(item, out temp))
                            {
                                multiplier.Append(temp.ToString());
                            }
                            else
                            {
                                buffer.Append(item);
                            }

                        }

                        stack.Pop();

                        number = Convert.ToInt32(multiplier.ToString());

                        for (int j = 0; j < number; j++)
                        {
                            builder.Append(buffer.ToString());
                        }

                        stack.Push(builder.ToString());

                        builder.Clear();
                        buffer.Clear();
                        multiplier.Clear();
                    }
                    else
                    {
                        stack.Push(s[i].ToString());
                    }

                }
                else
                {
                    stack.Push(s[i].ToString());
                }
            }

            while (stack.Count > 0)
            {
                builder.Append(stack.Pop());
            }

            return builder.ToString();
        }

        static void Main(string[] args)
        {
            var program = new Program();

            var result = program.DecodeString("3[a]2[bc]");
        }
    }
}
