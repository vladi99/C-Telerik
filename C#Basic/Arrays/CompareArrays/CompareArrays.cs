using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            string result = null;
            for (int i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    result = "Not equal";
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (result=="Not equal")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
