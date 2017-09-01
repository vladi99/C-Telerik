using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSAofNums
{
    class MMSAofNums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] nums = new double[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("min={0:f2}", nums.Min());
            Console.WriteLine("max={0:f2}", nums.Max());
            Console.WriteLine("sum={0:f2}", nums.Sum());
            Console.WriteLine("avg={0:f2}", nums.Average());
        }
    }
}
