using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string start = "<upcase>";
            string end = "</upcase>";

            char[] output = ExtractFromString(words, start, end);

            string result = new string(output);
            result = result.Replace(start, "");
            result = result.Replace(end, "");
            Console.WriteLine(result);
        }
        private static char[] ExtractFromString(
    string text, string startString, string endString)
        {
            int indexStart = -1, indexEnd = -1;
            char[] result = text.ToCharArray();
            while (true)
            {
                indexStart = text.IndexOf(startString, indexStart + 1);

                if (indexStart != -1)
                {
                    indexEnd = text.IndexOf(endString, indexEnd + 1);
                    for (int i = indexStart + startString.Length; i < indexEnd; i++)
                    {
                        string temp = text[i].ToString().ToUpper();
                        result[i] = Convert.ToChar(temp);
                    }
                }
                else
                    break;
            }            
            return result;
        }

    }
}
