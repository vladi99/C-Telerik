using System;
using System.Linq;

namespace SumOfSequences
{
    class SumOfSequences
    {
        private static int[] arr;

        private static int result;

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int k = n - int.Parse(input[1]);
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                arr = new int[k];
                result = 0;
                Comb(0, 0, n, k, numbers);
                Console.WriteLine(result);
            }
        }

        static void Comb(int index, int start, int n, int k, int[] numbers)
        {
            if (index >= k)
                PrintCombinations();
            else
                for (int i = start; i < n; i++)
                {
                    arr[index] = numbers[i];
                    Comb(index + 1, i + 1, n, k, numbers);
                }
        }

        private static void PrintCombinations()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
        }
    }
}
