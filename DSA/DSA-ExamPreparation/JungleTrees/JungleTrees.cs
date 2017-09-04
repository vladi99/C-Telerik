using System;
using System.Collections.Generic;

namespace JungleTrees
{
    class Problem1
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();

            int n = int.Parse(firstLine[0]);
            int maxX = int.Parse(firstLine[1]);
            int maxHeight = int.Parse(firstLine[2]);

            List<Node> trees = new List<Node>();
            bool[] visited = new bool[n];
            Node firstNode = new Node(int.MaxValue, 0, 0, 0);
            Node lastNode = new Node(int.MinValue, 0, 0, 0);

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                Node currentNode = new Node(int.Parse(line[0]), int.Parse(line[1]), 0, i);
                trees.Add(currentNode);
                if (currentNode.Coordinate < firstNode.Coordinate)
                {
                    firstNode = currentNode;
                }
                if (currentNode.Coordinate > lastNode.Coordinate)
                {
                    lastNode = currentNode;
                }
            }

            // BFS
            var q = new Queue<Node>();
            q.Enqueue(firstNode);

            while (q.Count > 0)
            {
                var currentTree = q.Dequeue();
                visited[currentTree.Index] = true;

                for (int i = 0; i < trees.Count; i++)
                {
                    var newCoordinate = trees[i].Coordinate;
                    var newHeight = trees[i].Height;

                    if (!visited[i] && Math.Abs(currentTree.Coordinate - newCoordinate) <= maxX && Math.Abs(currentTree.Height - newHeight) <= maxHeight)
                    {
                        if (newCoordinate == lastNode.Coordinate)
                        {
                            Console.WriteLine(currentTree.Steps + 1);
                            return;
                        }

                        var newTree = new Node(newCoordinate, newHeight, currentTree.Steps + 1, i);
                        visited[i] = true;
                        q.Enqueue(newTree);
                    }
                }
            }
            Console.WriteLine(-1);
        }
    }

    class Node
    {
        public int Coordinate { get; set; }

        public int Height { get; set; }

        public int Steps { get; set; }

        public int Index { get; set; }

        public Node(int coordinate, int height, int steps, int index)
        {
            this.Coordinate = coordinate;
            this.Height = height;
            this.Steps = steps;
            this.Index = index;
        }

    }
}