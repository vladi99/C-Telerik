using System;

namespace Zig_Zag
{
    class Program
    {
        private static int k;
        private static int n;
        private static int[] arr;
        private static bool[] used;
        private static int counter;

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            k = int.Parse(input[1]);
            if (k == 1)
            {
                Console.WriteLine(n);
            }
            else
            {
                arr = new int[k];
                used = new bool[n];

                GenerateVariationsNoReps(0, -1);
                Console.WriteLine(counter);
            }          
        }

        static void GenerateVariationsNoReps(int index, int prev)
        {
            if (index >= k)
                counter++;
            else
                for (int i = 0; i < n; i++)
                    if (!used[i] && ((index % 2 == 0 && prev < i) || (index % 2 == 1 && prev > i)))
                    {
                        used[i] = true;
                        arr[index] = i;
                        GenerateVariationsNoReps(index + 1, i);
                        used[i] = false;
                    }
        }
    }
}
