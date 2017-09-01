using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = IndexOfLargerThanNeighbours(numbers);
            Console.WriteLine(result);
        }

        private static int IndexOfLargerThanNeighbours(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    return i; 
                }
            }
            return -1;
        }
    }
}
