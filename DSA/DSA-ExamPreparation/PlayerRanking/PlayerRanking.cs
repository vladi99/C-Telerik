using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace PlayerRanking
{
    class PlayerRanking
    {
        static void Main(string[] args)
        {
            Ranklist ranklist = new Ranklist();
            StringBuilder builder = new StringBuilder();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "add")
                {
                    builder.AppendLine(ranklist.Add(command[1], command[2], int.Parse(command[3]), int.Parse(command[4])));
                }
                else if (command[0] == "find")
                {
                    builder.AppendLine(ranklist.Find(command[1]));
                }
                else if (command[0] == "ranklist")
                {
                    builder.AppendLine(ranklist.Standing(int.Parse(command[1]) - 1, int.Parse(command[2]) - 1));
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(builder.ToString().Trim());
        }
    }

    class Ranklist
    {
        private BigList<Player> players;
        private Dictionary<string, SortedSet<Player>> playersByType;

        public Ranklist()
        {
            players = new BigList<Player>();
            playersByType = new Dictionary<string, SortedSet<Player>>();
        }

        public string Add(string name, string type, int age, int position)
        {
            Player player = new Player(name, type, age);

            players.Insert(position - 1, player);

            if (!playersByType.ContainsKey(type))
            {
                playersByType[type] = new SortedSet<Player>();
            }

            playersByType[type].Add(player);
            return "Added player " + name + " to position " + position;
        }

        public string Find(string type)
        {
            if (!playersByType.ContainsKey(type))
            {
                return "Type " + type + ": ";
            }
            var result = playersByType[type].Take(5);
            return "Type " + type + ": " + string.Join("; ", result);
        }

        public string Standing(int start, int end)
        {
            var standing = players.Range(start, end - start + 1).Select((x, y) => y + start + 1 + ". " + x);
            return string.Join("; ", standing);
        }

    }


    class Player : IComparable<Player>
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int Age { get; set; }

        public Player(string name, string type, int age)
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;
        }

        public override string ToString()
        {
            return this.Name + "(" + this.Age +")";
        }

        public int CompareTo(Player other)
        {
            int comparisonResult = this.Name.CompareTo(other.Name);
            if (comparisonResult == 0)
            {
                comparisonResult = other.Age.CompareTo(this.Age);
            }

            return comparisonResult;
        }
    }
}
