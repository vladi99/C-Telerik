using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sequenceLenght = 1;
            int maxSequence = 0;
            for (int i = 0; i < n-1; i++)
            {
                if (arr[i] < arr[i+1])
                {
                    sequenceLenght++;
                }
                else
                {
                    if (sequenceLenght > maxSequence)
                    {
                        maxSequence = sequenceLenght;
                    }
                    sequenceLenght = 1;
                }
            }
            if (sequenceLenght > maxSequence)
            {
                maxSequence = sequenceLenght;
            }
            Console.WriteLine(maxSequence);
        }
    }
}
