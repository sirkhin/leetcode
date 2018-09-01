using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    public static class MergeSortSolver
    {
        public static List<int> Sort(List<int> array)
        {
            return Sort(array, 0, array.Count - 1);
        }

        private static List<int> Sort(List<int> array, int begin, int end)
        {
            if (!array.Any()) return new List<int>();

            var count = array.Count;

            if (count == 1) return array;

            var medium = begin + (begin + end) / 2;

            var left = Sort(array.Take(medium).ToList(), begin, medium);

            var right = Sort(array.Skip(medium).ToList(), medium + 1, end);

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
