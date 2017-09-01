using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitsOfWork
{
    class UnitsOfWork
    {
        static void Main(string[] args)
        {
            SortedSet<Unit> game = new SortedSet<Unit>();
            var dict = new Dictionary<string, Unit>();
            var builder = new StringBuilder();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "add")
                {
                    var unitName = command[1];
                    var unitToAdd = new Unit(unitName, command[2], int.Parse(command[3]));
                    if (game.Contains(unitToAdd))
                    {
                        builder.AppendLine("FAIL: " + unitName + " already exists!");
                    }
                    else
                    {
                        dict.Add(unitName, unitToAdd);
                        game.Add(unitToAdd);
                        builder.AppendLine("SUCCESS: " + unitName + " added!");
                    }
                }
                else if (command[0] == "remove")
                {
                    var unitName = command[1];
                    if (!dict.ContainsKey(unitName))
                    {
                        builder.AppendLine("FAIL: " + unitName + " could not be found!");
                    }
                    else
                    {
                        var unitToRemove = dict[unitName];
                        dict.Remove(unitName);
                        game.Remove(unitToRemove);
                        builder.AppendLine("SUCCESS: " + unitName + " removed!");
                    }
                }

                else if (command[0] == "find")
                {
                    List<Unit> result = game.Where((x) => x.Type == command[1])
                        .Take(10)
                        .ToList();

                    builder.Append("RESULT: ");
                    builder.AppendLine(string.Join(", ", result));
                }

                else if (command[0] == "power")
                {
                    int numberOfUnits = int.Parse(command[1]);
                    List<Unit> result = game
                            .Take(numberOfUnits)
                            .ToList();

                    builder.Append("RESULT: ");
                    builder.AppendLine(string.Join(", ", result));
                }
                else
                {
                    Console.WriteLine(builder.ToString().Trim());
                    break;
                }
            }
        }
    }

    class Unit : IComparable<Unit>
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int Attack { get; set; }

        public Unit(string name, string type, int attack)
        {
            this.Name = name;
            this.Type = type;
            this.Attack = attack;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as Unit;
            if (other == null)
            {
                return false;
            }
            return this.Name == other.Name;
        }

        public int CompareTo(Unit other)
        {
            var attackCompareResult = this.Attack.CompareTo(other.Attack);
            if (attackCompareResult == 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            else
            {
                return -attackCompareResult;
            }
        }
        public override string ToString()
        {
            return this.Name + "[" + this.Type + "](" + this.Attack + ")";
        }
    }
}
