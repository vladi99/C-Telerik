using System;
using System.Numerics;

namespace CatalanNums
{
    class CatalanNums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = (Factoriel(2 * n))/((Factoriel(n+1))*(Factoriel(n)));
            Console.WriteLine(result);
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
