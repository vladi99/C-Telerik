using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarketQueue
{
    class SuperMarketQueue
    {
        static void Main(string[] args)
        {
            Market market = new Market();
            StringBuilder builder = new StringBuilder();
            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Append")
                {
                    market.Append(command[1]);
                    builder.AppendLine("OK");
                }
                else if (command[0] == "Insert")
                {
                    builder.AppendLine(market.Insert(int.Parse(command[1]), command[2]));
                }
                else if (command[0] == "Find")
                {
                    builder.AppendLine(market.Find(command[1]).ToString());
                }
                else if (command[0] == "Serve")
                {
                    builder.AppendLine(market.Serve(int.Parse(command[1])));
                }
                else
                {
                    Console.WriteLine(builder.ToString().Trim());
                    Console.WriteLine(builder[1]);
                    break;
                }
            }
        }
    }

    public class Market
    {
        public Dictionary<string, int> Waiting { get; set; }

        public List<string> Q { get; set; }

        public int Start { get; set; }

        public Market()
        {
            this.Waiting = new Dictionary<string, int>();
            this.Q = new List<string>();
            this.Start = 0;
        }

        public void Append(string name)
        {
            this.Q.Add(name);
            if (!this.Waiting.ContainsKey(name))
            {
                this.Waiting[name] = 1;
            }
            else
            {
                this.Waiting[name]++;
            }
        }

        public string Insert(int position, string name)
        {
            if (position < 0 || position + this.Start > Q.Count)
            {
                return "Error";
            }
            this.Q.Insert(this.Start + position, name);
            if (!this.Waiting.ContainsKey(name))
            {
                this.Waiting[name] = 1;
            }
            else
            {
                this.Waiting[name]++;
            }
            return "OK";
        }

        public int Find(string name)
        {
            if (!this.Waiting.ContainsKey(name))
            {
                return 0;
            }
            return this.Waiting[name];
        }

        public string Serve(int count)
        {
            if (count + this.Start > Q.Count)
            {
                return "Error";
            }
            else
            {
                var builder = new StringBuilder();
                for (int i = this.Start; i < count + this.Start; i++)
                {
                    if (this.Waiting[Q[i]] > 0)
                    {
                        this.Waiting[Q[i]]--;
                    }
                    builder.Append(this.Q[i] + " ");
                }
                this.Start += count;
                return builder.ToString().Trim();
            }
        }
    }
}
