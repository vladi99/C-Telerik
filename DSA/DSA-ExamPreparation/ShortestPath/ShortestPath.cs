using System;
using System.Collections.Generic;
using System.Text;

namespace ShortestPath
{
    class ShortestPath
    {
        private static StringBuilder builder = new StringBuilder();
        private static int counter = 0;

        static char[] arr;

        static void Main(string[] args)
        {
            char[] directions = new char[] { 'L', 'R', 'S'  };
            string input = Console.ReadLine();
            arr = input.ToCharArray();

            List<int> indexes = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '*')
                {
                    indexes.Add(i);
                }
            }
            
            GenerateVariations(0, directions, indexes);
            Console.WriteLine(counter);
            Console.WriteLine(builder.ToString().Trim());

        }

        static void GenerateVariations(int index, char[] directions, List<int> indexes)
        {
            if (index >= indexes.Count)
            {
                counter++;
                builder.AppendLine(new string(arr));
            }
            else
            {
                for (int i = 0; i < directions.Length; i++)
                {
                    arr[indexes[index]] = directions[i];
                    GenerateVariations(index + 1, directions, indexes);
                }
            }
        }
    }
}
