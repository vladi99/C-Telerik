using System;
using System.Collections.Generic;

namespace MessageInBottle
{
    class MessageInBottle
    {
        private static SortedDictionary<char, string> cipher;
        private static string message;
        private static string currentLetters = "";
        private static List<string> results;

        static void Main(string[] args)
        {
            message = Console.ReadLine();
            string inputCipher = Console.ReadLine();

            cipher = new SortedDictionary<char, string>();

            ParseInput(inputCipher);
            
            results = new List<string>();

            Permutations(0);

            Console.WriteLine(results.Count);
            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i]);
            }
        }

        private static void Permutations(int index)
        {
            if (index >= message.Length)
            {
                results.Add(currentLetters);
            }
            else
            {
                foreach (var kvp in cipher)
                {
                    if (ContainsInBeginning(message, kvp.Value, index))
                    {
                        currentLetters += kvp.Key;
                        Permutations(index + kvp.Value.Length);
                        currentLetters = currentLetters.Substring(0, currentLetters.Length - 1);
                    }
                }
            }
        }

        private static bool ContainsInBeginning(string message, string value, int index)
        {
            if (index + value.Length <= message.Length)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (message[index + i] != value[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        private static void ParseInput(string inputCipher)
        {
            var startCount = 0;
            char currentLetter = ' ';
            int i = 0;
            for (i = 0; i < inputCipher.Length - 1; i++)
            {
                if (char.IsDigit(inputCipher[i]) && i > 0 && char.IsLetter(inputCipher[i + 1]))
                {
                    cipher[currentLetter] = inputCipher.Substring(startCount, i - startCount + 1);
                }
                else if (char.IsLetter(inputCipher[i]) && char.IsDigit(inputCipher[i + 1]))
                {
                    currentLetter = inputCipher[i];
                    startCount = i + 1;
                }
            }
            cipher[currentLetter] = inputCipher.Substring(startCount, i - startCount + 1);
        }
    }
}
