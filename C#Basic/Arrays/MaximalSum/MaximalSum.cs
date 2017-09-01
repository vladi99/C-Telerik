using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int maximalSum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    sum += arr[j];
                    if (sum > maximalSum)
                    {
                        maximalSum = sum;
                    }
                }
                sum = 0;
            }
            Console.WriteLine(maximalSum);
        }
    }
}
