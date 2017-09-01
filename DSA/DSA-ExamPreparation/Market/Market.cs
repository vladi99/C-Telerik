using System;
using System.Collections.Generic;
using System.Linq;

namespace Market
{
    class Market
    {
        static void Main(string[] args)
        {
            var products = new SortedSet<Product>();
            var productsByType = new Dictionary<string, SortedSet<Product>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] commandParts = command.Split(' ');
                string commandType = commandParts[0];
                if (commandType == "add")
                {
                    string productName = commandParts[1];
                    float productPrice = float.Parse(commandParts[2]);
                    string productType = commandParts[3];
                    var productToAdd = new Product(productName, productPrice, productType);
                    if (products.Contains(productToAdd))
                    {
                        Console.WriteLine("Error: Product {0} already exists", productToAdd.Name);
                    }
                    else
                    {
                        if (!(productsByType.ContainsKey(productToAdd.Type)))
                        {
                            productsByType[productToAdd.Type] = new SortedSet<Product>();
                        }
                        products.Add(productToAdd);
                        productsByType[productToAdd.Type].Add(productToAdd);
                        Console.WriteLine("Ok: Product {0} added successfully", productToAdd.Name);
                    }
                }
                else
                {
                    if (commandParts[2] == "type")
                    {
                        if (!(productsByType.ContainsKey(commandParts[3])))
                        {
                            Console.WriteLine("Error: Type {0} does not exists", commandParts[3]);
                        }
                        else
                        {
                            List<Product> result = productsByType[commandParts[3]]
                            .Take(10)
                            .ToList();
                            Console.Write("Ok: ");
                            Console.WriteLine(string.Join(", ", result));
                        }
                    }
                    else
                    {
                        if (commandParts.Length == 7)
                        {
                            List<Product> result = products
                                .Where(p => p.Price >= float.Parse(commandParts[4]) && p.Price <= float.Parse(commandParts[6]))
                                .Take(10)
                                .ToList();
                            if (result.Count == 0)
                            {
                                Console.WriteLine("Ok: ");
                            }
                            else
                            {
                                Console.Write("Ok: ");
                                Console.WriteLine(string.Join(", ", result));
                            }
                        }
                        else if (commandParts[3] == "from")
                        {
                            List<Product> result = products
                                .Where(p => p.Price > float.Parse(commandParts[4]))
                                .Take(10)
                                .ToList();
                            if (result.Count == 0)
                            {
                                Console.WriteLine("Ok: ");
                            }
                            else
                            {
                                Console.Write("Ok: ");
                                Console.WriteLine(string.Join(", ", result));
                            }
                        }
                        else
                        {
                            List<Product> result = products
                                .Where(p => p.Price <= float.Parse(commandParts[4]))
                                .Take(10)
                                .ToList();
                            if (result.Count == 0)
                            {
                                Console.WriteLine("Ok: ");
                            }
                            else
                            {
                                Console.Write("Ok: ");
                                Console.WriteLine(string.Join(", ", result));
                            }
                        }
                    }
                }
            }
        }
    }

    class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public float Price { get; set; }

        public string Type { get; set; }

        public Product(string name, float price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as Product;
            if (other == null)
            {
                return false;
            }
            return this.Name == other.Name;
        }

        public override string ToString()
        {
            return this.Name + "(" + this.Price + ")";
        }

        public int CompareTo(Product other)
        {
            var priceCompareResult = this.Price.CompareTo(other.Price);
            if (priceCompareResult == 0)
            {
                var namesCompareResult = this.Name.CompareTo(other.Name);
                if (namesCompareResult == 0)
                {
                    return this.Type.CompareTo(other.Type);
                }
                else
                {
                    return namesCompareResult;
                }
            }
            else
            {
                return priceCompareResult;
            }
        }
    }
}
