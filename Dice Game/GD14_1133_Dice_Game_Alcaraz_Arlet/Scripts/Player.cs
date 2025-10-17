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
        private List<Item> inventory = new List<Item>();

        // Stuff to reset when replaying:
        public int NumberOfRoomsVisited = 0;
        public int HP = 30;
        public void Reset()
        {
            NumberOfRoomsVisited = 0;
            availableItems.Clear();
            Initialize();
            HP = 30;
        }

        public void Initialize()
        {
            //do initialization stuff over here
            availableItems.Add("Sword", 6);
            availableItems.Add("Maze", 8);
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
        public string PlayerChoice()
        {
            //Tell player inventory
            string inventory = username + " you have the following weapons in your inventory: ";
            foreach (KeyValuePair<string, int> dice in availableItems)
            {
                inventory += " " + dice.Key + ",";
            }
            Console.WriteLine(inventory);
            string playerInput;
            //Validate input
            do
            {
                //Ask player input
                Console.WriteLine("What weapon do you want to use?\n");
                //ReadLine of the option
                playerInput = Console.ReadLine();
            } while (!availableItems.TryGetValue(playerInput, out int choice));

            //Return Choice

            return playerInput;
        }
        public int CpuDamage()
        {
            Random rand = new Random();
            int result = rand.Next(0, 9);
            return result; 
            //return availableItems.Keys.ToArray()[rand.Next(0,availableItems.Count)]; //The array looks like: D4, D6, D8, the random will trow a string with the choice
        }
        public void Inventory()
        {
            Console.WriteLine("You have the following items in your inventory:\n");

            //string inventory = username + " you have the following items in your inventory: ";
            //foreach (KeyValuePair<string, int> dice in availableItems)
            //{
            //    inventory += " " + dice.Key + ",";
            //}
            //Console.WriteLine(inventory);
        }
    }
}
