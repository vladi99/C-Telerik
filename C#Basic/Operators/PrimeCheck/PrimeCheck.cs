using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n%i == 0)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    
                }
                Console.WriteLine("true");
            }
        }
    }
}
