using System;
using System.Collections.Generic;

namespace Documentation
{
    class Documentation
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            char[] arr = input.ToCharArray();

            Greedy(arr);
            //BFS(arr);
        }

        private static void Greedy(char[] arr)
        {
            int result = 0;
            int i, j;
            for (i = 0, j = arr.Length - 1; i < j; ++i, --j)
            {
                while (i < arr.Length && (arr[i] == ' ' || arr[i] == ',' || arr[i] == '.' || arr[i] == '!' || arr[i] == '?'))
                {
                    i++;
                }
                while (j > 0 && arr[j] == ' ' || arr[j] == ',' || arr[j] == '.' || arr[j] == '!' || arr[j] == '?')
                {
                    j--;
                }
                if (i >= arr.Length || j < 0)
                {
                    break;
                }
                if (arr[i] != arr[j] && i < j)
                {
                    result += Math.Min(Math.Abs(arr[i] - arr[j]), 26 - Math.Abs(arr[i] - arr[j]));
                };
            }
            Console.WriteLine(result);
        }

        private static void BFS(char[] arr)
        {
            if (isPolindrome(arr))
            {
                Console.WriteLine(0);
            }
            else
            {
                HashSet<string> visited = new HashSet<string>();
                var q = new Queue<Node>();
                q.Enqueue(new Node(arr, 0));

                while (q.Count > 0)
                {
                    var currentNode = q.Dequeue();
                    visited.Add(new string(currentNode.CharArr));

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (currentNode.CharArr[i] == ' ' || currentNode.CharArr[i] == ',' || currentNode.CharArr[i] == '.' || currentNode.CharArr[i] == '!' || currentNode.CharArr[i] == '?')
                        {
                            continue;
                        }
                        char changedChar = (char)(currentNode.CharArr[i] + 1);

                        if (changedChar > 'z')
                        {
                            changedChar = 'a';
                        }

                        char[] newCharArr = new char[arr.Length];
                        Array.Copy(currentNode.CharArr, newCharArr, arr.Length);
                        newCharArr[i] = changedChar;
                        var newStr = new string(newCharArr);

                        if (!visited.Contains(newStr))
                        {
                            if (isPolindrome(newCharArr))
                            {
                                Console.WriteLine(currentNode.Steps + 1);
                                return;
                            }
                            visited.Add(newStr);
                            q.Enqueue(new Node(newCharArr, currentNode.Steps + 1));
                        }

                        char changedChar1 = (char)(currentNode.CharArr[i] - 1);

                        if (changedChar1 < 'a')
                        {
                            changedChar1 = 'z';
                        }

                        char[] newCharArr1 = new char[arr.Length];
                        Array.Copy(currentNode.CharArr, newCharArr1, arr.Length);
                        newCharArr1[i] = changedChar1;
                        var newStr1 = new string(newCharArr1);

                        if (!visited.Contains(newStr1))
                        {
                            if (isPolindrome(newCharArr1))
                            {
                                Console.WriteLine(currentNode.Steps + 1);
                                return;
                            }
                            visited.Add(newStr1);
                            q.Enqueue(new Node(newCharArr1, currentNode.Steps + 1));
                        }
                    }
                }
            }
        }

        private static bool isPolindrome(char[] arr)
        {
            int i, j;
            for (i = 0, j = arr.Length - 1; i < j; ++i, --j)
            {
                if (arr[i] == ' ' || arr[i] == ',' || arr[i] == '.' || arr[i] == '!' || arr[i] == '?')
                {
                    i++;
                }
                if (arr[j] == ' ' || arr[j] == ',' || arr[j] == '.' || arr[j] == '!' || arr[j] == '?')
                {
                    j--;
                }
                if (arr[i] != arr[j]) return false;
            }
            return true;
        }
    }

    public class Node
    {
        public char[] CharArr { get; set; }

        public int Steps { get; set; }

        public Node(char[] charArr, int steps)
        {
            this.CharArr = charArr;
            this.Steps = steps;
        }
    }
}
