using System;
using System.Linq;

namespace AcademyTasks
{
    class AcademyTasks
    {
        static void Main(string[] args)
        {
            int[] pleasantness = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int variety = int.Parse(Console.ReadLine());

            int endIndex = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < pleasantness.Length; i++)
            {
                if (pleasantness[i] < min)
                {
                    min = pleasantness[i];
                }
                if (pleasantness[i] > max)
                {
                    max = pleasantness[i];
                }
                if (max - min >= variety)
                {
                    endIndex = i;
                    break;
                }
            }
            int result = FindNumberOfProblems(pleasantness, variety, 0, int.MinValue, int.MaxValue, 0, endIndex);

            Console.WriteLine(pleasantness.Length);
        }

        private static int FindNumberOfProblems(int[] pleasantness, int variety, int index, int max, int min, int counter, int endIndex)
        {
            if (index > endIndex)
            {
                return 0;
            }

            if (pleasantness[index] > max)
            {
                max = pleasantness[index];
            }

            if (pleasantness[index] < min)
            {
                min = pleasantness[index];
            }

            if (max - min >= variety)
            {
                Console.WriteLine(counter + 1);
                Environment.Exit(0);
            }

            FindNumberOfProblems(pleasantness, variety, index + 2, max, min, counter + 1, endIndex);
            FindNumberOfProblems(pleasantness, variety, index + 1, max, min, counter + 1, endIndex);

            return counter;
        }
    }
}
