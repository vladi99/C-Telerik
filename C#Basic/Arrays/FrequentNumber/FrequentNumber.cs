using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxRepeat = 0;
            int repeating = 1;
            int repNum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        repeating++;
                    }
                }
                if (maxRepeat < repeating)
                {
                    maxRepeat = repeating;
                    repNum = arr[i];
                }
                repeating = 1;
            }
            Console.WriteLine("{0} ({1} times)", repNum, maxRepeat);
        }
    }
}
