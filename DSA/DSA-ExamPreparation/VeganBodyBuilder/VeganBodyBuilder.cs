using System;
using System.Collections.Generic;
using System.Linq;

namespace VeganBodyBuilder
{
    class VeganBodyBuilder
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            List<Node> sack = new List<Node>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                sack.Add(new Node(line[0], int.Parse(line[1]), int.Parse(line[2])));
            }

            KnapSackProblem problem = new KnapSackProblem();

            int totalValueOfItems = 0;
            List<Node> itemsToBePacked = problem.FindItemsToPack(sack, max, out totalValueOfItems);

            Console.WriteLine(totalValueOfItems);
            for (int i = 0; i < itemsToBePacked.Count; i++)
            {
                Console.WriteLine(itemsToBePacked[i]);
            }
        }
    }
        
    class KnapSackProblem
    {
        public List<Node> FindItemsToPack(List<Node> items, int capacity, out int totalValue)
        {
            int[,] price = new int[items.Count + 1, capacity + 1];
            bool[,] keep = new bool[items.Count + 1, capacity + 1];

            for (int i = 1; i <= items.Count; i++)
            {
                Node currentItem = items[i - 1];
                for (int space = 1; space <= capacity; space++)
                {
                    if (space >= currentItem.Weight)
                    {
                        int remainingSpace = space - currentItem.Weight;
                        int remainingSpaceValue = 0;
                        if (remainingSpace > 0)
                        {
                            remainingSpaceValue = price[i - 1, remainingSpace];
                        }
                        int currentItemTotalValue = currentItem.Protein + remainingSpaceValue;
                        if (currentItemTotalValue > price[i - 1, space])
                        {
                            keep[i, space] = true;
                            price[i, space] = currentItemTotalValue;
                        }
                        else
                        {   
                            keep[i, space] = false;
                            price[i, space] = price[i - 1, space];
                        }
                    }
                }
            }

            List<Node> itemsToBePacked = new List<Node>();

            int res = 0;
            int remainSpace = capacity;
            int item = items.Count;
            while (item > 0)
            {
                bool toBePacked = keep[item, remainSpace];
                if (toBePacked)
                {
                    itemsToBePacked.Add(items[item - 1]);
                    res += items[item - 1].Protein;
                    remainSpace = remainSpace - items[item - 1].Weight;
                }
                item--;
            }

            totalValue = res;
            return itemsToBePacked;
        }

    }



    class Node
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public int Protein { get; set; }

        public Node(string name, int weight, int protein)
        {
            this.Name = name;
            this.Weight = weight;
            this.Protein = protein;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
