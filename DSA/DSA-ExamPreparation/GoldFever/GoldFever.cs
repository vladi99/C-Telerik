using System;
using System.Linq;

namespace GoldFever
{
    class GoldFever
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] goldPrice = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long result = 0;
            for (int i = n - 1; i > 0; i--)
            {
                if (goldPrice[i] > goldPrice[i - 1])
                {
                    result += goldPrice[i] - goldPrice[i - 1];
                    goldPrice[i - 1] = goldPrice[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
