using System;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace ShoppingCenter
{
    class ShoppingCenter
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            int n = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int index = input.IndexOf(' ');
                string command = input.Substring(0, index);
                string parameters = input.Substring(index + 1);

                if (command == "AddProduct")
                {
                    string[] properties = parameters.Split(';');
                    builder.AppendLine(shop.AddProduct(properties[0], float.Parse(properties[1]), properties[2]));
                }
                else if(command == "DeleteProducts")
                {
                    string[] properties = parameters.Split(';');
                    if (properties.Length == 2)
                    {
                        builder.AppendLine(shop.DeleteProductsByPair(properties[0], properties[1]));
                    }
                    else
                    {
                        builder.AppendLine(shop.DeleteProductsByProducer(properties[0]));
                    }
                }
                else if (command == "FindProductsByName")
                {
                    builder.AppendLine(shop.FindProductsByName(parameters));
                }
                else if (command == "FindProductsByPriceRange")
                {
                    var properties = parameters.Split(';');
                    builder.AppendLine(shop.FindProductsByPriceRange(float.Parse(properties[0]), float.Parse(properties[1])));
                }
                else
                {
                    builder.AppendLine(shop.FindProductsByProducer(parameters));
                }
            }

            Console.WriteLine(builder.ToString().Trim());
        }
    }

    class Shop
    {
        public MultiDictionary<string, Product> ProductsByProducer { get; set; }
        public MultiDictionary<string, Product> ProductsByName { get; set; }
        public MultiDictionary<Pair<string, string>, Product> ProductsByPair { get; set; }

        public OrderedMultiDictionary<float, Product> ProductsByPrice { get; set; }

        public Shop()
        {
            this.ProductsByProducer = new MultiDictionary<string, Product>(true);
            this.ProductsByName = new MultiDictionary<string, Product>(true);
            this.ProductsByPair = new MultiDictionary<Pair<string, string>, Product>(true);
            this.ProductsByPrice = new OrderedMultiDictionary<float, Product>(true);
        }

        public string AddProduct(string name, float price, string producer)
        {
            Product product = new Product(name, price, producer);

            ProductsByProducer.Add(producer, product);
            ProductsByName.Add(name, product);
            ProductsByPair.Add(new Pair<string, string>(name, producer), product);
            ProductsByPrice.Add(price, product);

            return "Product added";
        }

        public string DeleteProductsByPair(string name, string producer)
        {
            var pair = new Pair<string, string>(name, producer);
            var ProductsForDeletion = ProductsByPair[pair];

            int forDeletion = ProductsForDeletion.Count;

            foreach (var product in ProductsForDeletion)
            {
                ProductsByProducer.Remove(product.Producer, product);
                ProductsByPrice.Remove(product.Price, product);
                ProductsByName.Remove(product.Name, product);
            }

            ProductsByPair.Remove(pair);

            if (forDeletion == 0)
            {
                return "No products found";
            }
            else
            {
                return forDeletion + " products deleted";
            }
        }

        public string DeleteProductsByProducer(string producer)
        {
            var ProductsForDeletion = ProductsByProducer[producer];

            int forDeletion = ProductsForDeletion.Count;

            foreach (var product in ProductsForDeletion)
            {
                ProductsByPrice.Remove(product.Price, product);
                ProductsByName.Remove(product.Name, product);
                ProductsByPair.Remove(new Pair<string, string>(product.Name, product.Producer), product);
            }

            ProductsByProducer.Remove(producer);
            
            if (forDeletion == 0)
            {
                return "No products found";
            }
            else
            {
                return forDeletion + " products deleted";
            }
        }

        public string FindProductsByName(string name)
        {
            var products = ProductsByName[name].OrderBy(p => p);

            if (products.Any())
            {
                return string.Join(Environment.NewLine, products);
            }
            else
            {
                return "No products found";
            }
        }

        public string FindProductsByPriceRange(float from, float to)
        {
            var products = ProductsByPrice.Range(from, true, to, true).Values.OrderBy(p => p);

            if (products.Any())
            {
                return string.Join(Environment.NewLine, products);
            }
            else
            {
                return "No products found";
            }
        }

        public string FindProductsByProducer(string producer)
        {
            var products = ProductsByProducer[producer].OrderBy(p => p);

            if (products.Any())
            {
                return string.Join(Environment.NewLine, products);
            }
            else
            {
                return "No products found";
            }
        }
    }

    class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public float Price { get; set; }

        public string Producer { get; set; }

        public Product(string name, float price, string producer)
        {
            this.Name = name;
            this.Price = price;
            this.Producer = producer;
        }

        public override string ToString()
        {
            return "{" + string.Format("{0};{1};{2:F2}", this.Name, this.Producer, this.Price) + "}";
        }

        public int CompareTo(Product other)
        {
            int compareResult = this.Name.CompareTo(other.Name);
            if (compareResult == 0)
            {
                compareResult = this.Producer.CompareTo(other.Producer);
            }
            if (compareResult == 0)
            {
                compareResult = this.Price.CompareTo(other.Price);
            }
            return compareResult;
        }
    }
}
