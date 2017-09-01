using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string searchedWord = Console.ReadLine();
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            StringBuilder temp = new StringBuilder();
            string[] sentences = text.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries); 
            for (int i = 0; i < sentences.Length; i++)
            {
                temp.Clear();
                for (int j = 0; j < sentences[i].Length; j++)
                {
                    if (!char.IsLetter(sentences[i][j]))
                    {
                        temp.Append(sentences[i][j]); //parse NON-letter symbols
                    }
                }
                char[] splitChars = temp.ToString().ToCharArray();
                string[] words = sentences[i].Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
                if (words.Contains(searchedWord))
                {
                    result.Append(sentences[i].Trim());
                    result.Append(". ");
                }
            }
            Console.WriteLine(result.ToString().Trim());
        }
    }
}
