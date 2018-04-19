using System;
using System.Collections.Generic;
using System.Linq;

namespace HammingDistance
{
    /*
        461. Hamming Distance

        The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

        Given two integers x and y, calculate the Hamming distance.

        Note:
        0 ≤ x, y < 231.

        Example:

        Input: x = 1, y = 4

        Output: 2

        Explanation:
        1   (0 0 0 1)
        4   (0 1 0 0)
               ↑   ↑

        The above arrows point to positions where the corresponding bits are different.
     */
    public class HammingDistanceCounter
    {
        public int CountHammingDistance(int x, int y)
        {
            var byteX = GetBinaryRepresentation(x);
            var byteY = GetBinaryRepresentation(y);

            var max = Math.Max(byteX.Length, byteY.Length);

            if (byteX.Length < max)
            {
                var list = byteX.ToList();
                for (int j = 0; j < max - byteX.Length; j++)
                {
                    list.Insert(j, false);
                }

                byteX = list.ToArray();
            }
            else if (byteY.Length < max)
            {
                var list = byteY.ToList();
                for (int j = 0; j < max - byteY.Length; j++)
                {
                    list.Insert(j, false);
                }

                byteY = list.ToArray();
            }

            var result = new bool[max];

            for (int i = 0; i < max; i++)
            {
                result[i] = (byteX[i] ^ byteY[i]);
            }

            var count = result.Count(r => r);

            return count;
        }

        private static bool[] GetBinaryRepresentation(int i)
        {
            List<bool> result = new List<bool>();
            while (i > 0)
            {
                int m = i % 2;
                i = i / 2;
                result.Add(m == 1);
            }
            result.Reverse();
            return result.ToArray();
        }
    }
}
