using System;

namespace DogeCoin
{
    class DogeCoin
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split();

            int n = int.Parse(dimensions[0]);
            int m = int.Parse(dimensions[1]);

            int[,] matrix = new int[n, m];
            int k = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < k; i++)
            {
                string[] cell = Console.ReadLine().Split();
                int row = int.Parse(cell[0]);
                int col = int.Parse(cell[1]);
                matrix[row, col]++;
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        continue;
                    }
                    int left = 1000000000;
                    int up = 1000000000;
                    if (row > 0)
                    {
                        up = matrix[row - 1, col];
                    }
                    if (col > 0)
                    {
                        left = matrix[row, col - 1];
                    }
                    int add = Math.Min(left, up);
                    result = add + matrix[row, col];
                    matrix[row, col] = result;
                }
            }

            Console.WriteLine(result);
        }
    }
}
