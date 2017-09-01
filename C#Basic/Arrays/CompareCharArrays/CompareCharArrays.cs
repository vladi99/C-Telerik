using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().ToArray();
            char[] secondArr = Console.ReadLine().ToArray();
            int smallerArrSize = Math.Min(firstArr.Length, secondArr.Length); 
            for (int i = 0; i < smallerArrSize; i++)
            {
                if (firstArr[i]==secondArr[i])
                {
                    continue;
                }
                else if (firstArr[i]>secondArr[i])
                {
                    Console.WriteLine(">");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("<");
                    Environment.Exit(0);
                }
            }
            if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine(">");
            }
            else if (firstArr.Length < secondArr.Length)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}
