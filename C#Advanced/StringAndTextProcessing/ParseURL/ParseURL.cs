using System;

namespace ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            string adress = Console.ReadLine();
            int index = adress.IndexOf('/');
            string protocol = adress.Substring(0, index - 1);
            int serverIndex = adress.IndexOf('/', index + 2);
            string server = adress.Substring(index + 2, serverIndex - (index + 2));
            string resource = adress.Substring(serverIndex);
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
