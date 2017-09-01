using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAreaInMatrix
{
    class LargestAreaInMatrix
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                string[] spl = line.Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(spl[col]);
                }
            }

            bool[,] calculated = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            int counter = 1;
            int maxCounter = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (!calculated[row, col])
                    {
                        counter = DepthSearch(row, col, matrix, calculated);
                        if (maxCounter < counter)
                        {
                            maxCounter = counter;
                        }
                    }                   
                }
            }
            Console.WriteLine(maxCounter);
        }

        private static int DepthSearch(int row, int col, int[,] matrix, bool[,] calc)
        {
            int counter = 1;
            calc[row, col] = true;
            if ((row - 1 >= 0) && (matrix[row - 1, col] == matrix[row, col]) && !calc[row - 1, col])
            {
                counter += DepthSearch(row - 1, col, matrix, calc);
            }
            if ((row + 1 < matrix.GetLength(0)) && (matrix[row + 1, col] == matrix[row, col]) && !calc[row + 1, col])
            {
                counter += DepthSearch(row + 1, col, matrix, calc);
            }
            if ((col - 1 >= 0) && (matrix[row, col - 1] == matrix[row, col]) && !calc[row, col - 1])
            {
                counter += DepthSearch(row, col - 1, matrix, calc);
            }
            if ((col + 1 < matrix.GetLength(1)) && (matrix[row, col + 1] == matrix[row, col]) && !calc[row, col + 1])
            {
                counter += DepthSearch(row, col + 1, matrix, calc);
            }
            return counter;
        }
    }
}
