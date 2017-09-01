using System;
using System.Collections.Generic;

namespace RiskWinsRiskLoses
{
    class RiskWinsRiskLoses
    {
        static void Main(string[] args)
        {
            string startStr = Console.ReadLine();
            string endStr = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            var forbidden = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                forbidden.Add(Console.ReadLine());
            }

            // BFS
            var visited = new HashSet<string>();
            var q = new Queue<Node>();
            var startNode = new Node(startStr, 0);
            q.Enqueue(startNode);

            while (q.Count > 0)
            {
                var currentNode = q.Dequeue();
                visited.Add(currentNode.StrNumber);
                for (int i = 0; i < 5; i++)
                {
                    var newStr = currentNode.StrNumber;
                    char changedChar = (char)(newStr.ToCharArray()[i] + 1);

                    if (changedChar < '0')
                    {
                        changedChar = '9';
                    }

                    if (changedChar > '9')
                    {
                        changedChar = '0';
                    }

                    var charArr = newStr.ToCharArray();
                    charArr[i] = changedChar;
                    newStr = new string(charArr);

                    if (!visited.Contains(newStr) && !forbidden.Contains(newStr))
                    {
                        if (newStr == endStr)
                        {
                            Console.WriteLine(currentNode.Steps + 1);
                            return;
                        }

                        var newNode = new Node(newStr, currentNode.Steps + 1);
                        visited.Add(newStr);
                        q.Enqueue(newNode);
                    }

                    var newStr1 = currentNode.StrNumber;
                    char changedChar1 = (char)(newStr1.ToCharArray()[i] - 1);

                    if (changedChar1 < '0')
                    {
                        changedChar1 = '9';
                    }

                    if (changedChar1 > '9')
                    {
                        changedChar1 = '0';
                    }

                    var charArr1 = newStr1.ToCharArray();
                    charArr1[i] = changedChar1;
                    newStr1 = new string(charArr1);

                    if (!visited.Contains(newStr1) && !forbidden.Contains(newStr1))
                    {
                        if (newStr1 == endStr)
                        {
                            Console.WriteLine(currentNode.Steps + 1);
                            return;
                        }

                        var newNode = new Node(newStr1, currentNode.Steps + 1);
                        visited.Add(newStr1);
                        q.Enqueue(newNode);
                    }
                }
            }

            Console.WriteLine(-1);

            // int result = Greedy(start, end, forbidden);

            // Console.WriteLine(result);
        }

        private static int Greedy(int[] start, int[] end, int[][] fobidden)
        {
            int result = 0;

            for (int i = 0; i < 5; i++)
            {
                result += Math.Min(Math.Abs(start[i] - end[i]), 10 - Math.Abs(start[i] - end[i]));
            }

            return result;
        }
    }

    public class Node
    {
        public string StrNumber { get; set; }

        public int Steps { get; set; }

        public Node(string strNumber, int steps)
        {
            this.StrNumber = strNumber;
            this.Steps = steps;
        }
    }
}
