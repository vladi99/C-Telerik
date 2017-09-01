using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisors
{
    class Divisors
    {
        private static int[] arr;

        private static int n;

        private static int[] variations;

        private static bool[] used;

        private static int min = int.MaxValue;

        private static int minValue;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            variations = new int[n];
            used = new bool[n];

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                arr[i] = current;
            }
            GenerateVariationsNoReps(0);
            Console.WriteLine(minValue);
        }

        static void GenerateVariationsNoReps(int index)
        {
            if (index >= n)
                PrintVariations();
            else
                for (int i = 0; i < n; i++)
                    if (!used[i])
                    {
                        used[i] = true;
                        variations[index] = arr[i];
                        GenerateVariationsNoReps(index + 1);
                        used[i] = false;
                    }
        }

        private static void PrintVariations()
        {
            int counter = 0;
            int number = 0;
            for (int i = 0; i < variations.Length; i++)
            {
                number += variations[i] * Convert.ToInt32(Math.Pow(10, variations.Length - i - 1));
            }

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }

            if (counter < min)
            {
                min = counter;
                minValue = number;            
            }
            else if (counter == min) {
                if (number < minValue)
                {
                    minValue = number;
                }
            }
        }
    }
}
