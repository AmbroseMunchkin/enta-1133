using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{

    internal class Player
    {
        public string username = "";
        

        //class level variables that persist
        //public Dictionary<string, int> availableItems = new Dictionary<string, int>();
        public List<Item> inventory = new List<Item>();

        // Stuff to reset when replaying:
        public int NumberOfRoomsVisited = 0;
        public int HP = 30;
        public void Reset()
        {
            NumberOfRoomsVisited = 0;
            inventory.Clear();
            Initialize();
            HP = 30;
        }

        public void Initialize()
        {
            //do initialization stuff over here
            inventory.Add(new Weapon.Sword { Name = "Sword" });
            inventory.Add(new Weapon.Maze { Name = "Maze" });
        }
        public string User()
        {
            Console.Write("So, dear wandering soul, what’s your name?");
            Console.WriteLine();
            username = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Well " + username + " my name is Arlet Alcaraz and I'll be your guide, let me teach you how things work here~"); //Added this here because i didnt knew how to call the username in the game manager
            return username;
        }
        
        public void Inventory()
        {
            Console.WriteLine( username + " you have the following items in your inventory:\n");
            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
    }
}
