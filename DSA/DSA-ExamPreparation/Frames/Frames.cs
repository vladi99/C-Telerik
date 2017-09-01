using System;
using System.Collections.Generic;
using System.Linq;

namespace Frames
{
    class Frames
    {
        private static HashSet<string> result;

        private static int n;

        private static bool[] used;

        private static Frame[] permutation;

        static void Main(string[] args)
        {
            result = new HashSet<string>();
            n = int.Parse(Console.ReadLine());
            var inputFrames = new Frame[n];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                inputFrames[i] = new Frame(line[0], line[1]);
            }
            used = new bool[n];
            permutation = new Frame[n];
            Permutations(0, inputFrames);
            PrintResult(result);
        }

        private static void Permutations(int index, Frame[] inputFrames)
        {
            if (index >= n)
            {
                string perm = string.Join(" | ", permutation.ToList());
                result.Add(perm);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;

                        permutation[index] = inputFrames[i];
                        Permutations(index + 1, inputFrames);

                        permutation[index] = new Frame(inputFrames[i].Second, inputFrames[i].First);
                        Permutations(index + 1, inputFrames);

                        used[i] = false;
                    }
                }
            }
        }

        private static void PrintResult(HashSet<string> result)
        {
            Console.WriteLine(result.Count);
            var resultList = result.ToList();
            resultList.Sort();
            foreach (var item in resultList)
            {
                Console.WriteLine(item);
            }
        }
        class Frame
        {
            public int First { get; set; }

            public int Second { get; set; }

            public Frame(int first, int second)
            {
                this.First = first;
                this.Second = second;
            }

            public override string ToString()
            {
                return "(" + this.First + ", " + this.Second + ")";
            }

            public void Swap()
            {
                int temp = this.First;
                this.First = this.Second;
                this.Second = temp;
            }
        }
    }
}
