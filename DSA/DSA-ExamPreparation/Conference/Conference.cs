using System;
using System.Collections.Generic;

namespace Conference
{
    class Conference
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            bool[] visited = new bool[n];
            Dictionary<int, HashSet<int>> graph = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < m; i++)
            {
                string[] line = Console.ReadLine().Split();
                int first = int.Parse(line[0]);
                int second = int.Parse(line[1]);

                if (!graph.ContainsKey(first))
                {
                    graph[first] = new HashSet<int>();
                }
                if (!graph.ContainsKey(second))
                {
                    graph[second] = new HashSet<int>();
                }
                graph[first].Add(second);
                graph[second].Add(first);
            }

            List<long> componentsNodesCount = new List<long>();
            foreach (int node in graph.Keys)
            {
                int componentCount = DFS(node, graph, visited); ;
                if (componentCount != 0)
                {
                    componentsNodesCount.Add(componentCount);
                }
            }

            long singletonsCount = n - graph.Keys.Count;

            long pairsCombinations = 0;
            for (int i = 0; i < componentsNodesCount.Count - 1; i++)
            {
                pairsCombinations += componentsNodesCount[i] * singletonsCount;
                for (int j = i + 1; j < componentsNodesCount.Count; j++)
                {
                    pairsCombinations += componentsNodesCount[i] * componentsNodesCount[j];
                }
            }

            if (singletonsCount > 0)
            {
                if (componentsNodesCount.Count > 0)
                {
                    pairsCombinations += componentsNodesCount[componentsNodesCount.Count - 1] * singletonsCount;
                }

                pairsCombinations += (singletonsCount * (singletonsCount - 1)) / 2;
            }

            Console.WriteLine(pairsCombinations);
        }

        private static int DFS(int node, IDictionary<int, HashSet<int>> graph, bool[] visited)
        {
            int result = 0;
            if (!visited[node])
            {
                visited[node] = true;
                result++;
                if (graph.ContainsKey(node))
                {
                    foreach (int child in graph[node])
                    {
                        if (!visited[child])
                        {
                            result += DFS(child, graph, visited);
                        }
                    }
                }
            }

            return result;
        }
    }
}
