using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCaclulations
{
    class IntegerCaclulations
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long min = minimumOf(array);
            Console.WriteLine(min);

            long max = maximumOf(array);
            Console.WriteLine(max);

            double average = averageOf(array);
            Console.WriteLine("{0:f2}", average);

            long sum = sumOf(array);
            Console.WriteLine(sum);

            long product = productOfElements(array);
            Console.WriteLine(product);


        }

        private static long productOfElements(long[] array)
        {
            long product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }

        private static long sumOf(long[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        private static double averageOf(long[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (sum / array.Length);
        }

        private static long maximumOf(long[] array)
        {
            long max = long.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        private static long minimumOf(long[] array)
        {
            long min = long.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
