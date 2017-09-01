using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int searchedNumber = int.Parse(Console.ReadLine());
            int appearance = CountAppearance(numbers, searchedNumber);
            Console.WriteLine(appearance);
        }

        private static int CountAppearance(int[] numbers, int searchedNumber)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchedNumber)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
