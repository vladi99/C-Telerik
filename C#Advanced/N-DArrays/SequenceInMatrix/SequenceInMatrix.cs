using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
{
    class SequenceInMatrix
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
            //columns
            int counter = 1;
            int maxCounter = 1;
            for (int col = 0; col < cols; col++)
            {
                for (int row = 1; row < rows; row++)
                {
                    if (matrix[row, col] == matrix[row - 1, col])
                    {
                        counter++;
                        if (maxCounter < counter)
                        {
                            maxCounter = counter;

                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
                counter = 1;
            }
            //lines
            for (int row = 0; row < rows; row++)
            {
                for (int col = 1; col < cols; col++)
                {
                    if (matrix[row, col] == matrix[row, col - 1])
                    {
                        counter++;
                        if (maxCounter < counter)
                        {
                            maxCounter = counter;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
                counter = 1;
            }
            //diogonals
            for (int c = 1; c < cols; c++)
            {
                for (int row = 1, col = c; row < rows && col < cols; row++, col++)
                {
                    if (matrix[row, col] == matrix[row - 1, col - 1])
                    {
                        counter++;
                        if (maxCounter < counter)
                        {
                            maxCounter = counter;
                        }
                    }
                }
                counter = 1;
            }
            counter = 1;
            for (int c = cols - 2; c > 0; c--)
            {
                for (int row = 1, col = c; row < rows && col >= 0; row++, col--)
                {
                    if (matrix[row, col] == matrix[row - 1, col + 1])
                    {
                        counter++;
                        if (maxCounter < counter)
                        {
                            maxCounter = counter;
                        }
                    }
                }
                counter = 1;
            }            
            Console.WriteLine(maxCounter);
        }
    }
}
