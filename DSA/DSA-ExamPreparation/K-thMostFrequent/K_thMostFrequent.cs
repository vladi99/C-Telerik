using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace K_thMostFrequent
{
    class K_thMostFrequent
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
            StringBuilder builder = new StringBuilder();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "ADD")
                {
                    int number = int.Parse(command[1]);
                    if (!dict.ContainsKey(number))
                    {
                        dict[number] = 0;
                    }
                    dict[number]++;
                    builder.AppendLine("Ok: " + number + " added");
                }
                else if (command[0] == "REMOVE")
                {
                    int number = int.Parse(command[1]);
                    if (!dict.ContainsKey(number))
                    {
                        builder.AppendLine("Error: Number " + number + " not found");
                    }
                    else
                    {
                        dict[number]--;
                        if (dict[number] <= 0)
                        {
                            dict.Remove(number);
                        }
                        builder.AppendLine("Ok: Number " + number + " removed");
                    }

                }
                else if (command[0] == "GET")
                {
                    int number = int.Parse(command[1]);
                    if (number > dict.Count || number < 1)
                    {
                        builder.AppendLine("Error: " + number + " is invalid K");
                    }
                    else
                    {
                        var sorted = dict.OrderByDescending(x => x.Value);
                        var result = sorted.ElementAt(number - 1).Key;
                        builder.AppendLine("Ok: Found " + result);
                    }
                }
                else
                {
                    Console.WriteLine(builder.ToString().Trim());
                    break;
                }
            }
        }
    }
}
