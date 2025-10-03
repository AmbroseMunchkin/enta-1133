using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class Player
    {
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
        public void User()
        {

            Console.Write("So, dear wandering soul, what’s your name?");
            Console.WriteLine();
            String username = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Well " + username + " my name is Arlet and I'll be your opponent, let me teach you how things work here~"); //Added this here because i didnt knew how to call the username in the game manager
        }
    }
}