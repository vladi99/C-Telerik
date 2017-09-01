using System;
using System.Numerics;

namespace Businessmen
{
    class Businessmen
    {
        static void Main(string[] args)
        {
            var factorials = new BigInteger[141];
            factorials[0] = 1;
            for (int i = 1; i < factorials.Length; i++)
            {
                factorials[i] = factorials[i - 1] * i;
            }
            int n = int.Parse(Console.ReadLine());
            BigInteger result = factorials[n] / (factorials[n/2] * factorials[n/2+1]);
            Console.WriteLine(result);
        }
    }
}
