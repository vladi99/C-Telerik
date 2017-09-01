using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTBridges
{
    class MSTBridges
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            List<Edge> edges = new List<Edge>();

            for (int i = 0; i < m; i++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                edges.Add(new Edge(line[0], line[1], line[2]));
            }

            int maximalWeight = int.Parse(Console.ReadLine());

            edges.Sort((x, y) => y.CompareTo(x));

            int mstCost = 0;
            int[] color = new int[m];
            for (int i = 0; i < m; i++)
            {
                color[i] = i;
            }

            for (int i = 0; i < edges.Count; i++)
            {
                Edge currentEdge = edges[i];
                if (color[currentEdge.a] != color[currentEdge.b])
                {
                    if (currentEdge.cost < maximalWeight)
                    {
                        mstCost++;
                    }

                    int oldColor = color[currentEdge.b];
                    for (int j = 0; j < m; j++)
                    {
                        if (color[j] == oldColor)
                        {
                            color[j] = color[currentEdge.a];
                        }
                    }
                }
            }

            Console.WriteLine(mstCost);
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
