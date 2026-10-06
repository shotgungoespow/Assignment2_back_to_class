using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Assignment2_back_to_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ShellType> ammunition = new List<ShellType>();

            ShellType High_Explosive = new ShellType { Name = "High Explosive", Cost = 1, Damage = 3, Radius = 4, Range = 5 };
            ShellType Armor_Piercing = new ShellType { Name = "Armor Piercing", Cost = 2, Damage = 8, Radius = 1, Range = 5 };
            ShellType Lightweight = new ShellType { Name = "Lightweight", Cost = 2, Damage = 2, Radius = 3, Range = 9 };
            ShellType Cluster = new ShellType { Name = "Cluster", Cost = 4, Damage = 2, Radius = 9, Range = 4 };
            ShellType Kinetic_Pen = new ShellType { Name = "Kinetic Pen", Cost = 5, Damage = 10, Radius = 1, Range = 7 };


            ammunition.Add(High_Explosive);
            ammunition.Add(Armor_Piercing);
            ammunition.Add(Lightweight);
            ammunition.Add(Cluster);
            ammunition.Add(Kinetic_Pen);

            List<ShellType> Expensive = ammunition.FindAll(n => n.Cost > 3);
            foreach (ShellType item in Expensive)
            {
                int discount = 1;
                item.Cost -= discount;
                //Console.WriteLine(item.Cost);
            }

            Dictionary<string, ShellType> shells = new Dictionary<string, ShellType>()
            {
                ["HE"] = new ShellType() { Name = "High Explosive", Cost = 1, Damage = 3, Radius = 4, Range = 5 },
                ["AP"] = new ShellType() { Name = "Armor Piercing", Cost = 2, Damage = 8, Radius = 1, Range = 5 },
                ["LW"] = new ShellType() { Name = "Lightweight", Cost = 2, Damage = 2, Radius = 3, Range = 9 },
                ["CL"] = new ShellType() { Name = "Cluster", Cost = 4, Damage = 2, Radius = 9, Range = 4 },
                ["KP"] = new ShellType() { Name = "Kinetic Pen", Cost = 5, Damage = 10, Radius = 1, Range = 7 }

            };

            List<Player> players = new List<Player>();
            Player player1 = new Player { Id = 1, UserName = "Bob", Level = 6, Favorite_Shell = shells["AP"] };
            Player player2 = new Player { Id = 1, UserName = "Greg", Level = 10, Favorite_Shell = shells["HE"] };
            players.Add(player1);
            players.Add(player2);

            Console.WriteLine("search user");
            string input = Console.ReadLine();
            ShellType found_fave = null;
            foreach (Player player in players)
            {
                if (player.UserName == input)
                {
                    found_fave = player.Favorite_Shell; break;
                }
            }
            Console.WriteLine("user " + input + "'s favorite shell is: " + found_fave.Name);
            Console.ReadKey();





        }
    }
}
