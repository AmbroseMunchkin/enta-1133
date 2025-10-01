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

            Console.Write("Please enter your username:");
            String username = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome " + username + " to Dice Rolling! My name is Arlet Alcaraz and today is 25 of september 2025"); //Added this here because i didnt knew how to call the username in the game manager
            Console.WriteLine(" ___   ___   _     _         ___   ___       ___   _   ____ \r\n| |_) / / \\ | |   | |       / / \\ | |_)     | | \\ | | | |_  \r\n|_| \\ \\_\\_/ |_|__ |_|__     \\_\\_/ |_| \\     |_|_/ |_| |_|__ \r\n                                                            \r\n                                                            \r\n                                                            \r\n");
        }
    }
}