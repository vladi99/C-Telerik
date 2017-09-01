using System;

namespace NotDivisibleNums
{
    class NotDivisibleNums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
