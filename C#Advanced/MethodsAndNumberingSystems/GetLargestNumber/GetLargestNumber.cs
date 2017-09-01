using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = GetMax(numbers[0], GetMax(numbers[1], numbers[2]));
            Console.WriteLine(max);
        }
        static int GetMax(int a, int b)
        {
            if (a < b)
            {
                return b;
            }
            else if (a>b)
            {
                return a;
            }
            else
            {
                return a;
            }
        }
    }
}
