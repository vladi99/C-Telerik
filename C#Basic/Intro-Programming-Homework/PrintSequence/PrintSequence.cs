﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            int startPoint = 2;
            int lenghtOfSequence = 10;

            for (int i = startPoint; i <= lenghtOfSequence + startPoint - 1; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
