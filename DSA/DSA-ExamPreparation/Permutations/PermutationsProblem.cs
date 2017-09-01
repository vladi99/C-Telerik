using System;

namespace Permutations
{
    class PermutationsProblem
    {
        private static int n;
        private static long k;
        private static int[] arr;
        private static bool[] used;
        private static long counter;

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            k = long.Parse(input[1]);
            arr = new int[n];
            used = new bool[n];
            Permutations(0);
        }

        private static void Permutations(int index)
        {
            if (index >= n)
            {
                counter++;
                if (counter == k)
                {
                    Console.WriteLine(string.Join(" ", arr));
                    Environment.Exit(0);
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (!used[i - 1])
                    {
                        used[i - 1] = true;
                        arr[index] = i;
                        Permutations(index + 1);
                        used[i - 1] = false;
                    }
                }
            }
        }
    }
}
