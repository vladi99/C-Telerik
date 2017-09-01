using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    public static class Sorting
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int counter = Bfs(numbers, n, k);
            Console.WriteLine(counter);
        }

        private static int Bfs(int[] numbers, int n, int k)
        {
            if (IsSorted(numbers))
            {
                return 0;
            }

            var used = new Dictionary<int, int>(); // Key -> state, Value -> minimum operations to achieve this state
            var queue = new Queue<int[]>();

            queue.Enqueue(numbers);
            used.Add(GetHashCode(numbers), 0);

            while (queue.Count > 0)
            {
                var state = queue.Dequeue();

                // For all possible states from the current (applying allowed operations)
                for (int i = 0; i + k <= n; i++)
                {
                    var newState = state.Clone() as int[];

                    Array.Reverse(newState, i, k);

                    if (!used.ContainsKey(GetHashCode(newState)))
                    {
                        var operations = used[GetHashCode(state)];
                        if (IsSorted(newState))
                        {
                            return operations + 1;
                        }

                        used.Add(GetHashCode(newState), operations + 1);
                        queue.Enqueue(newState);
                    }
                }
            }

            return -1;
        }

        private static int GetHashCode(IEnumerable<int> state)
        {
            int hashCode = 0;
            foreach (var number in state)
            {
                hashCode = (hashCode * 8) + number;
            }

            return hashCode;
        }

        private static bool IsSorted(int[] state)
        {
            for (int i = 1; i < state.Length; i++)
            {
                if (state[i] < state[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
