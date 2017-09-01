using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBreckets
{
    class CorrectBreckets
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int countLeft = 0;
            int countRight = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    countLeft++;
                }
                if (str[i] == ')')
                {
                    countRight++;
                }
            }
            if (countRight==countLeft)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
