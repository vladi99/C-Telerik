using System;

namespace BitsTime
{
    class BitsTime
    {
        // 0110
        // 1101001
        private const float ChangingCost = 1;
        private const float DeletingZeroCost = 0.9;
        private const float AddingZeroCost = 1.1;
        private const float DeletingOneCost = 0.8;
        private const float AddingOneCost = 1.2;

        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            float result = Iterative(start, end);
            Console.WriteLine(result);
        }

        private static float Iterative(string start, string target)
        {
            int n = start.Length;
            int m = target.Length;
            float[,] matrix = new float[n + 1, m + 1];

            for (int i = 1; i <= n; i++)
            {
                matrix[i, 0] = matrix[i - 1, 0] + (start[i - 1] == '0' ? DeletingZeroCost : DeletingOneCost);
            }

            for (int j = 1; j <= m; j++)
            {
                matrix[0, j] = matrix[0, j - 1] + (target[j - 1] == '0' ? AddingZeroCost : AddingOneCost);
            }

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= m; col++)
                {
                    matrix[row, col] = Minimum(matrix[row - 1, col] + (start[row - 1] == '0' ? DeletingZeroCost : DeletingOneCost), // delete
                                               matrix[row, col - 1] + (target[col - 1] == '0' ? AddingZeroCost : AddingOneCost),    // add
                                               matrix[row - 1, col - 1] + (target[col - 1] == start[row - 1] ? 0 : ChangingCost));  // change
                }
            }
            return matrix[n, m];
        }

        private static void Print(float[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,6}", matrix[i, j]));
                }
                Console.WriteLine();
            }
        }

        private static float Minimum(float a, float b, float c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}
