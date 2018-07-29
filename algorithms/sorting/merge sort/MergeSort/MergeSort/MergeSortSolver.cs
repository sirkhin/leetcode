using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    public static class MergeSortSolver
    {
        public static List<int> Sort(List<int> array)
        {
            if (!array.Any()) return new List<int>();

            var count = array.Count;

            if (count == 1) return array;

            var left = array.Take(count / 2).ToList();
            var right = array.Skip(count / 2).ToList();

            left = Sort(left);
            right = Sort(right);

            var merged = Merge(left, right);

            return merged.ToList();
        }

        private static int[] Merge(List<int> left, List<int> right)
        {
            var totalLength = left.Count + right.Count;

            var merged = new int[totalLength];

            var j = 0;
            var k = 0;

            for (int i = 0; i < totalLength; i++)
            {
                var outOfLeft = j == left.Count;
                var outOfRight = k == right.Count;

                if (outOfLeft)
                {
                    merged[i] = right[k];
                    k++;
                    continue;
                }

                if (outOfRight)
                {
                    merged[i] = left[j];
                    j++;
                    continue;
                }

                if (left[j] < right[k])
                {
                    merged[i] = left[j];
                    j++;
                }
                else
                {
                    merged[i] = right[k];
                    k++;
                }
            }

            return merged;
        }
    }
}
