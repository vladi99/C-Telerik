using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sequence = 1;
            int maxSequence = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    sequence++;
                }
                else
                {
                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                    }
                    sequence = 1;
                }
            }
            if (sequence>maxSequence)
            {
                maxSequence = sequence;
            }
            Console.WriteLine(maxSequence);
        }
    }
}
