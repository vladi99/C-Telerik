using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger mfactoriel = Factoriel(m);
            BigInteger kfactoriel = Factoriel(k);
            BigInteger output = mfactoriel / kfactoriel;
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
