using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string str = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                result.Append(str[i]);
                if (i==str.Length-1)
                {
                    break;
                }
                while (str[i]==str[i+1])
                {
                    i++;
                    if (i==str.Length-1)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
