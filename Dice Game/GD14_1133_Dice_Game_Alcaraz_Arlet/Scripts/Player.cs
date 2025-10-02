using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class Player
    {
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