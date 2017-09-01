using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKNumbers
{
    class MaximalKNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (arr[i]>=arr[j])
                    {
                        continue;
                    }
                    else
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;                        
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
