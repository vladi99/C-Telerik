using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenProduct
{
    class OddEvenProduct
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] nums = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long oddProduct = 1;
            long evenProduct = 1;
            for (int i = 0; i < nums.Length; i+=2)
            {
                oddProduct *= nums[i];
            }
            for (int j = 1; j < nums.Length; j+=2)
            {
                evenProduct *= nums[j];
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes " + oddProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
            }
        }
    }
}
