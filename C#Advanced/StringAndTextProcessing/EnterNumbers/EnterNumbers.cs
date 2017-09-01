using System;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            string result = ReadNumbers(start, end);
            Console.WriteLine(result);
        }

        private static string ReadNumbers(int start, int end)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                
                try
                {
                    arr[i] = int.Parse(Console.ReadLine());
                    if (arr[i] <= start || arr[i] >= end)
                    {
                        return "Exception";
                    }
                }
                catch (FormatException)
                {
                    return "Exception";
                }                
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= arr[i + 1])
                {
                    return "Exception";
                }
            }
            return start + " < " + String.Join(" < ", arr) + " < " + end;
        }
    }
}
