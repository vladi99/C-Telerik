using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            DateTime beggining = DateTime.Now;
            Array.Sort(arr);
            DateTime end = DateTime.Now;
            TimeSpan duration = end - beggining;
            Console.WriteLine(duration.TotalMilliseconds);

        }
    }
}
