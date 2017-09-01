using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> sumOfArrays = AddArrays(firstArray, secondArray);
            Console.WriteLine(String.Join(" ", sumOfArrays));
        }

        private static List<int> AddArrays(int[] firstArray, int[] secondArray)
        {
            int adder = 0;
            int[] biggerArray = firstArray.Length >= secondArray.Length ? firstArray : secondArray;
            int[] smallerArray = firstArray.Length < secondArray.Length ? firstArray : secondArray;
            List<int> results = new List<int>();
            int[] filledArray = new int[biggerArray.Length];
            for (int i = 0; i < smallerArray.Length; i++)
            {
                filledArray[i] = smallerArray[i];
            }
            int result = 0;

            for (int i = 0; i < biggerArray.Length; i++)
            {
                result = biggerArray[i] + filledArray[i];
                if (result > 9)
                {
                    result = result % 10 + adder;
                    adder++;
                    if (adder > 1)
                    {
                        adder = 1;
                    }
                }
                else
                {
                    result = result + adder;
                    if (result > 9)
                    {
                        result = result % 10;
                    }
                    adder = 0;
                }
                results.Add(result);
            }
            if (biggerArray[biggerArray.Length-1] + filledArray[filledArray.Length-1] > 9 || result == 0)
            {
                results.Add(1);
            }
            return results;
        }
    }
}