using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int searchedNum = int.Parse(Console.ReadLine());
            
            int index = Search(arr, searchedNum);
            Console.WriteLine(index);
            

        }
        static int Search(int[] array, int value)
        {
            int low = 0, high = array.Length - 1, midpoint = 0;

            while (low <= high)
            {
                midpoint = low + (high - low) / 2;

                // check to see if value is equal to item in array
                if (value == array[midpoint])
                {
                    return midpoint;
                }
                else if (value < array[midpoint])
                    high = midpoint - 1;
                else
                    low = midpoint + 1;
            }

            // item was not found
            return -1;
        }
    }
}
