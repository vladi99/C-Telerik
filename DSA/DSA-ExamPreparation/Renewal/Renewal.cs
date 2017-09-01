using System;
using System.Collections.Generic;

namespace Renewal
{
    class Renewal
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[,] roads = new bool[n, n];
            List<Edge> edges = new List<Edge>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    roads[i, j] = line[j] == '0' ? false : true;
                }
            }

            int[,] construction = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    construction[i, j] = line[j] < 'a' ? line[j] - 'A' : line[j] - 'a' + 26;
                }
            }

            int[,] deconstruction = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    deconstruction[i, j] = line[j] < 'a' ? line[j] - 'A' : line[j] - 'a' + 26;
                }
            }

            // build tree and calculate destruction cost
            int deconstructionCost = 0;
            int mstCost = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (roads[i, j])
                    {
                        edges.Add(new Edge(i, j, -deconstruction[i, j]));
                        deconstructionCost += deconstruction[i, j];
                    }
                    else
                    {
                        edges.Add(new Edge(i, j, construction[i, j]));
                    }
                }
            }

            // solve the MST on the graph, using Kruskal's algorithm
            edges.Sort();

            int[] color = new int[n];
            for (int i = 0; i < n; i++)
            {
                color[i] = i;
            }

            for (int i = 0; i < edges.Count; i++)
            {
                Edge currentEdge = edges[i];
                if (color[currentEdge.a] != color[currentEdge.b])
                {
                    mstCost += currentEdge.cost;

                    int oldColor = color[currentEdge.b];
                    for (int j = 0; j < n; j++)
                    {
                        if (color[j] == oldColor)
                        {
                            color[j] = color[currentEdge.a];
                        }
                    }
                }
            }

            int result = deconstructionCost + mstCost;
            Console.WriteLine(result);
        }
    }
    class Edge : IComparable<Edge>
    {
        public int a;
        public int b;
        public int cost;

        public Edge(int a, int b, int cost)
        {
            this.a = a;
            this.b = b;
            this.cost = cost;
        }

        public int CompareTo(Edge e)
        {
            return cost - e.cost;
        }
    }
}
