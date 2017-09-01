using System;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger Factorial = CalculateFactroial(n);
            Console.WriteLine(Factorial);
        }
        private static BigInteger CalculateFactroial(int n)
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
