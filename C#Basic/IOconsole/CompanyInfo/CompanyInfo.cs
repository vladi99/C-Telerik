using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAdress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAdress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            if (faxNumber.Length==0)
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}", faxNumber);
            }
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName,lastName, age, managerPhone);  
        }
    }
}
