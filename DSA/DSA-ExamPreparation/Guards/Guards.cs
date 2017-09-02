using System;

namespace Guards
{
    class Guards
    {
        static void Main(string[] args)
        {
            string[] rowsCols = Console.ReadLine().Split();

            int rows = int.Parse(rowsCols[0]);
            int cols = int.Parse(rowsCols[1]);
            int[,] matrix = new int[rows, cols];
            bool[,] forbiden = new bool[rows, cols];
            int guards = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = 1;
                }
            }
            for (int i = 0; i < guards; i++)
            {
                string[] line = Console.ReadLine().Split();
                int row = int.Parse(line[0]);
                int col = int.Parse(line[1]);

                forbiden[row, col] = true;
                if (line[2] == "R")
                {
                    if (col != cols - 1)
                    {
                        matrix[row, col + 1] = 3;
                    }               
                }
                else if (line[2] == "L")
                {
                    if (col != 0)
                    {
                        matrix[row, col - 1] = 3;
                    }
                }
                else if (line[2] == "U")
                {
                    if (row != 0)
                    {
                        matrix[row - 1, col] = 3;
                    }
                }
                else if (line[2] == "D")
                {
                    if (row != rows - 1)
                    {
                        matrix[row + 1, col] = 3;
                    }
                }
            }
            int result = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        continue;
                    }
                    int left = 1000000000;
                    int up = 1000000000;
                    if (row > 0)
                    {
                        if (!forbiden[row - 1, col])
                        {
                            up = matrix[row - 1, col];
                        }
                    }
                    if (col > 0)
                    {
                        if (!forbiden[  row, col - 1])
                        {
                            left = matrix[row, col - 1];
                        }
                    }
                    int add = Math.Min(left, up);
                    result = add + matrix[row, col];
                    matrix[row, col] = result;
                }
            }
            if (result >= 1000000000)
            {
                Console.WriteLine("Meow");
            }
            else
            {
                Console.WriteLine(result);
            }

        }

        private static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,-12}", matrix[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
