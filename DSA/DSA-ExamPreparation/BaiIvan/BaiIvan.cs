using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiIvan
{
    class BaiIvan
    {
        private static Node startNode = new Node(0, 0, 0);

        private static HashSet<int> visited = new HashSet<int>();

        private static List<Node> graph = new List<Node>();

        private static double min = double.MaxValue;

        static void Main(string[] args)
        {
            double m = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());

            graph.Add(startNode);
            for (int i = 0; i < n; i++)
            {
                var coordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();
                graph.Add(new Node(i + 1, coordinates[0], coordinates[1]));
            }

            // DFS(startNode);

            Recursion(0, 0);
            Console.WriteLine("{0:f2}", min * m);
        }

        private static void Recursion(double distance, int index)
        {
            if (index >= graph.Count)
            {
                return;
            }
            if (graph[index].X == 0 && graph[index].Y == 0 && visited.Count == graph.Count)
            {
                if (distance < min)
                {
                    min = distance;
                }
            }

            if (visited.Contains(graph[index].Id))
            {
                return;
            }

            for (int i = 1; i < graph.Count; i++)
            {
                var currentDistance = CalculateDistance(graph[index], graph[(index + i) % graph.Count]);

                visited.Add(graph[index].Id);
                distance += currentDistance;
                Recursion(distance, (index + i) % graph.Count);
                distance -= currentDistance;
                visited.Remove(graph[index].Id);
            }
        }



        // public static void DFS(Node node)
        // {
        //     var nodes = new Stack<Node>();
        //     nodes.Push(node);
        //     visited.Add(node.Id);
        // 
        //     while (nodes.Count != 0)
        //     {
        //         Node currentNode = nodes.Pop();
        //         Console.WriteLine(currentNode.X);
        // 
        //         for (int i = 0; i < graph.Count; i++)
        //         {
        //             if (!visited.Contains(graph[i].Id))
        //             {
        //                 nodes.Push(graph[i]);
        //                 visited.Add(graph[i].Id);
        //             }
        //         }
        //     }
        // }

        private static double CalculateDistance(Node a, Node b)
        {
            var distance = Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
            return distance;
        }
    }

    class Node
    {
        public int Id { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public Node(int id, double x, double y)
        {
            this.Id = id;
            this.X = x;
            this.Y = y;
        }
    }
}
