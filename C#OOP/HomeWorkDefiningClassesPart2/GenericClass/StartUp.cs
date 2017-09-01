namespace Generic
{
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            var genericListTest = new GenericList<int>();

            for (int i = 0; i < 21; i++)
            {
                genericListTest.Add(i);
            }

            Console.WriteLine(genericListTest.ToString()); // printing all list elements

            genericListTest.AddAtIndex(7, 77);

            Console.WriteLine(genericListTest.ToString()); // after we added the new element

            Console.WriteLine(genericListTest.Min());
            Console.WriteLine(genericListTest.Max());
        }
    }
}
