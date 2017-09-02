using System;
using System.Numerics;

namespace TheRingsOfTheAcademy
{
    class TheRingsOfTheAcademy
    {
        static void Main(string[] args)
        {
            var factorials = new BigInteger[22];
            factorials[0] = 1;
            for (int i = 1; i < factorials.Length; i++)
            {
                factorials[i] = factorials[i - 1] * i;
            }
            int[] arr = new int[22];
            BigInteger result = 1;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int index = int.Parse(Console.ReadLine());
                arr[index]++;
            }

            for (int i = 0; i < 22; i++)
            {
                if (arr[i] > 1)
                {
                    result *= factorials[arr[i]];
                }
            }
            Console.WriteLine(result);
        }
    }
}
