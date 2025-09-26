using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class RandomTurn
    {
         
        public static void Turn()
        {
            Random random = new Random();

            int playerTurn = random.Next(1, 3); //Wanted to make the random turn simple and in it's own script to use it in future proyects

            if (playerTurn == 1)
            {
                Console.WriteLine("You go first!"); //Wanted to use the player name but i dont know how to call the username from the player script
                Console.WriteLine();
                DieRoller.PlayerStart();
                Console.WriteLine();
                
            }
            else
            {
                Console.WriteLine("Computer goes first!");
                DieRoller.ComputerRolls();
                Console.WriteLine();
            }
        }
    }
}
