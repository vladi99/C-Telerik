using System;

namespace QuadronacciRectangle
{
    class QuadronacciRectangle
    {
        static void Main(string[] args)
        {
            int[] firstNumbers = new int[4];
            for (int i = 0; i < 4; i++)
            {
                firstNumbers[i] = int.Parse(Console.ReadLine());
            }
            
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            long[] sequence = new long[rows * cols];

            for (int i = 0; i < sequence.Length; i++)
            {
                if (i < 4)
                {
                    sequence[i] = firstNumbers[i];
                }
                else
                {
                    sequence[i] = sequence[i - 1] + sequence[i - 2] + sequence[i - 3] + sequence[i - 4];
                }
                if (i % cols == cols - 1 && i > 0)
                {
                    Console.WriteLine(sequence[i]);
                }
                else
                {
                    Console.Write(sequence[i] + " ");
                }
            }
        }
    }
}
