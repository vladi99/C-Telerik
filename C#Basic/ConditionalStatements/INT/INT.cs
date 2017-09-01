using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INT
{
    class INT
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type=="integer")
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num + 1);
            }
            else if (type == "real")
            {
                double real = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}",(real + 1));
            }
            else if (type == "text")
            {
                string text = Console.ReadLine();
                Console.WriteLine(text + "*");
            }
        }
    }
}
