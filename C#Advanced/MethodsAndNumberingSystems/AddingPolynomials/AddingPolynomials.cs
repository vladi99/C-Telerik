using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        static void Main()
        {
            string size = Console.ReadLine();
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sumOfArrays = sumArrays(firstArray, secondArray);
            Console.WriteLine(String.Join(" ", sumOfArrays));
        }

        private static int[] sumArrays(int[] firstArray, int[] secondArray)
        {
            int[] sumOfArray = new int[firstArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                sumOfArray[i] = firstArray[i] + secondArray[i];
            }
            return sumOfArray;
        }
    }
}
