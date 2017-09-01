using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillMatrix
{
    class FillMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            int[,] matrix1 = new int[n , n];
            int temp = 1;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix1[row, col] = temp++;
                }
            }


            int[,] matrix2 = new int[n, n];
            int temp2 = 1;
            for (int row = 0; row < n; row++)
            {
                if (row % 2 == 1)
                {
                    for (int col = n - 1; col >= 0; col--)
                    {
                        matrix2[row, col] = temp2++;
                    }
                }
                else
                {
                    for (int col = 0; col < n; col++)
                    {
                        matrix2[row, col] = temp2++;
                    }
                }

            }

            int[,] matrix3 = new int[n, n];
            int temp3 = 0;
            matrix3[0, 0] = 1;
            for (int i = 1; i < n; i++)
            {
                matrix3[i,0] = i + matrix3[i - 1, 0];
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col < n - row; col++)
                {
                    matrix3[row, col] = matrix3[row, col - 1] + col + 1 + temp3;
                }
                temp3++;
            }
            matrix3[n-1, n-1] = n * n;
            for (int i = n-2; i >= 1; i--)
            {
                matrix3[i, n-1] = matrix3[i + 1, n-1] - ((n-1)-i);
            }
            temp3 = 0;

            for (int row = n-1; row >= 1; row--)
            {
                for (int col = n-2; col > n - 1 - row; col--)
                {
                    matrix3[row, col] = matrix3[row, col + 1] - (n - col) - temp3;
                }
                temp3++;
            }

            int[,] matrix4 = new int[n,n];
            int minRow = 0;
            int maxRow = n - 1;
            int minCol = 0;
            int maxCol = n - 1;
            int counter = 1;
            string direction = "down";
            do
            {
                if (direction == "down")
                {
                    for (int row = minRow; row <= maxRow; row++)
                    {
                        matrix4[row, minCol] = counter++;
                    }
                    minCol++;
                    direction = "right";
                }
                if (direction == "right")
                {
                    for (int col = minCol; col <= maxCol; col++)
                    {
                        matrix4[maxRow, col] = counter++;
                    }
                    maxRow--;
                    direction = "up";
                }
                if (direction == "up")
                {
                    for (int row = maxRow; row >= minRow; row--)
                    {
                        matrix4[row, maxCol] = counter++;
                    }
                    maxCol--;
                    direction = "left";
                }
                if (direction == "left")
                {
                    for (int col = maxCol; col >= minCol; col--)
                    {
                        matrix4[minRow, col] = counter++;
                    }
                    minRow++;
                    direction = "down";
                }
            } while (maxRow >= minRow && maxCol >= minCol);

            if (symbol == "a")
            {
                for (int col = 0; col < n; col++)
                {
                    for (int row = 0; row < n; row++)
                    {                        
                        if (row == n - 1)
                        {
                            Console.Write(matrix1[row, col]);
                        }
                        else
                        {
                            Console.Write(matrix1[row, col] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            if (symbol == "b")
            {
                for (int col = 0; col < n; col++)
                {
                    for (int row = 0; row < n; row++)
                    {
                        if (row == n - 1)
                        {
                            Console.Write(matrix2[row, col]);
                        }
                        else
                        {
                            Console.Write(matrix2[row, col] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            if (symbol == "c")
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (col == n - 1)
                        {
                            Console.Write(matrix3[row, col]);
                        }
                        else
                        {
                            Console.Write(matrix3[row, col] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            if (symbol == "d")
            {
                for (int col = 0; col < n; col++)
                {
                    for (int row = 0; row < n; row++)
                    {
                        if (row == n - 1)
                        {
                            Console.Write(matrix4[col, row]);
                        }
                        else
                        {
                            Console.Write(matrix4[col, row] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
