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
        public Dictionary<string, int> availableDice = new Dictionary<string, int>();

        public void Initialize()
        {
            //do initialization stuff over here
            availableDice.Add("D4", 4);
            availableDice.Add("D6", 6);
            availableDice.Add("D8", 8);
            availableDice.Add("D10", 10);
            availableDice.Add("D12", 12);
            availableDice.Add("D20", 20);
            availableDice.Add("D100", 100);
        }
        public string User()
        {
            Console.Write("So, dear wandering soul, what’s your name?");
            Console.WriteLine();
            username = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Well " + username + " my name is Arlet and I'll be your opponent, let me teach you how things work here~"); //Added this here because i didnt knew how to call the username in the game manager
            return username;
        }
        public string PlayerChoice()
        {
            //Tell player inventory
            string inventory = username + " you have the following dice still in your inventory: ";
            foreach (KeyValuePair<string, int> dice in availableDice)
            {
                inventory += " " + dice.Key + ",";
            }
            Console.WriteLine(inventory);
            string playerInput;
            //Validate input
            do
            {
                //Ask player input
                Console.WriteLine("What dice do you want to use?\n");
                //ReadLine of the option
                playerInput = Console.ReadLine();
            } while (!availableDice.TryGetValue(playerInput, out int choice));

            //Return Choice

            return playerInput;
        }
        public string CPUChoice()
        {
            Random rand = new Random();
            return availableDice.Keys.ToArray()[rand.Next(0,availableDice.Count)]; //The array looks like: D4, D6, D8, the random will trow a string with the choice
        }
    }
}