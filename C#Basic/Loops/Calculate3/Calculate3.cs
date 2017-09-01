using System;
using System.Numerics;

namespace Calculate3
{
    class Calculate3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger output = Factoriel(n) / (Factoriel(k) * (Factoriel(n - k)));
            Console.WriteLine(output);
        }
        private static BigInteger Factoriel(int n)
        {
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
