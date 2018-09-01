using System;

namespace NumberOfIslands
{
    class Program
    {
        public int NumIslands(char[,] grid)
        {
            var width = grid.GetLength(0);
            var height = grid.GetLength(1);

            var unionFind = new UnionFind(width, height);

            for (int i = 0; i < width; i++)
            for (int j = 0; j < height; j++)
            {
                if (grid[i, j] == '1')
                {
                    unionFind.Put(i, j);
                }
            }

            return unionFind.NumberOfComponents;
        }

        static void Main(string[] args)
        {
            //var grid = new char[,]
            //{
            //    {'1', '1', '1', '1', '0'},
            //    {'1', '1', '0', '1', '0'},
            //    {'1', '1', '0', '0', '0'},
            //    {'0', '0', '0', '0', '0'}
            //};

            var grid = new [,]
            {
                {'1', '1', '1'},
                {'0', '1', '0'},
                {'1', '1', '1'}
            };

            var program = new Program();

            var numberOfIslands = program.NumIslands(grid);

            Console.WriteLine(numberOfIslands);
            Console.ReadLine();
        }
    }
}
