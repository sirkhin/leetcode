using System;

namespace KthLargestElementInArray
{
    class Program
    {
        public static int KthLargestElement(int[] nums, int k)
        {
            var lo = 0;
            var hi = nums.Length - 1;
            var t = nums.Length - k;

            while (hi > lo)
            {
                var j = Partition(nums, lo, hi);

                if (j < t) lo = j + 1;
                else if (j > t) hi = j - 1;
                else return nums[t];
            }

            return nums[t];
        }

        private static int Partition(int[] nums, int lo, int hi)
        {
            var i = lo;
            var j = hi + 1;

            while (true)
            {
                while (nums[++i] < nums[lo])
                {
                    if (i >= hi) break;   
                }

                while (nums[--j] > nums[lo])
                {
                    if (j <= lo)
                    {
                        break;
                    }
                }

                if (i >= j) break;
                Exchange(nums, i, j);
            }

            Exchange(nums, lo, j);
            return j;
        }

        private static void Exchange(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        static void Main(string[] args)
        {
            var nums = new int[] {3, 2, 1, 5, 6, 4};
            var k = 2;

            var item = KthLargestElement(nums, k);

            Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
