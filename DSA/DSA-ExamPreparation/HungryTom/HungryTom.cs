using System;
using System.Collections.Generic;
using System.Linq;

namespace HungryTom
{
    class HungryTom
    {
        private static Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        private static bool[] visited;
        private static List<int> arr;
        private static List<List<int>> results = new List<List<int>>();

        static void Main(string[] args)
        {         
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            visited = new bool[n];
            arr = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }
            for (int i = 0; i < m; i++)
            {
                string[] line = Console.ReadLine().Split();
                int first = int.Parse(line[0]);
                int second = int.Parse(line[1]);
                graph[first].Add(second);
                graph[second].Add(first);
            }

            Recursion(1, 0);
            if (results.Count == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                results.Sort((x, y) =>
                {
                    int result = 0;
                    for (int i = 0; i < x.Count; i++)
                    {
                        result = x[i].CompareTo(y[i]);
                        if (result != 0)
                        {
                            return result;
                        }
                    }
                    return result;
                });
                Console.WriteLine(results.Count);
                for (int i = 0; i < results.Count; i++)
                {
                    Console.WriteLine(string.Join(" ", results[i]));
                }
            }
            
        }

        private static void Recursion(int index, int visitedCount)
        {
            if (index > graph.Count)
            {
                return;
            }
            if (index == 1 && visitedCount == graph.Count)
            {
                List<int> copy = new List<int>(arr);
                copy.Add(1);
                results.Add(copy);
            }

            if (visited[index - 1])
            {
                return;
            }

            for (int i = 0; i < graph[index].Count; i++)
            {
                visitedCount++;
                visited[index - 1] = true;
                arr.Add(index);
                Recursion(graph[index][i], visitedCount);
                arr.RemoveAt(arr.Count - 1);
                visitedCount--;
                visited[index - 1] = false;
            }
        }
    }
}
