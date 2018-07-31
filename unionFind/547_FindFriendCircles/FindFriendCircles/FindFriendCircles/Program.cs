using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFriendCircles
{
    class Program
    {
        public int FindCircleNum(int[,] M)
        {
            var numberOfStudents = M.GetLength(0);

            var unionFind = new WeightedUnionFind(numberOfStudents);

            for (int i = 0; i < numberOfStudents; i++)
            for (int j = i + 1; j < numberOfStudents; j++)
            {
                unionFind.Union(i, j, M[i, j]);
            }

            return unionFind.FriendCirclesCount;
        }

        static void Main(string[] args)
        {
            var M = new int[3, 3] {{1, 1, 0}, {1, 1, 1}, {0, 1, 1}};

            var program = new Program();

            var count = program.FindCircleNum(M);

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
