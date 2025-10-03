using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class GameManager
    {
        public void ProgramStart()
        {
            Intro();
            Player player = new Player(); //Fixed how the intro is since it was rude to start by asking the player name
            player.User();
            Rules();     //Added the rules as its own private void since i will only call it once
            RollOrDie();
            Outro();
            Player playerVariableName = new Player();
            playerVariableName.Initialize();
            Player playerVariableName2 = new Player();
            playerVariableName2.Initialize();
        }
        private void Intro()
        {
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("Hello, hello hello! Uh, welcome to");
            Console.WriteLine(" ___   ___   _     _         ___   ___       ___   _   ____ \r\n| |_) / / \\ | |   | |       / / \\ | |_)     | | \\ | | | |_  \r\n|_| \\ \\_\\_/ |_|__ |_|__     \\_\\_/ |_| \\     |_|_/ |_| |_|__ \r\n                                                            \r\n                                                            \r\n                                                            ");
            Console.WriteLine("A game where your soul is at stake!");
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine();
        }
        private void RollOrDie()
        {
            RandomTurn randomTurn = new RandomTurn();
            randomTurn.Turn();
        }
        private void Outro()
        {
            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("Thank you for keeping me entertained dear wandering soul~");
            Console.WriteLine("You fought for your soul with great bravery; you can keep it...");
            Console.WriteLine("░        ░░░      ░░░       ░░░░░░░░░   ░░░  ░░░      ░░░  ░░░░  ░\r\n▒  ▒▒▒▒▒▒▒▒  ▒▒▒▒  ▒▒  ▒▒▒▒  ▒▒▒▒▒▒▒▒    ▒▒  ▒▒  ▒▒▒▒  ▒▒  ▒  ▒  ▒\r\n▓      ▓▓▓▓  ▓▓▓▓  ▓▓       ▓▓▓▓▓▓▓▓▓  ▓  ▓  ▓▓  ▓▓▓▓  ▓▓        ▓\r\n█  ████████  ████  ██  ███  █████████  ██    ██  ████  ██   ██   █\r\n█  █████████      ███  ████  ████████  ███   ███      ███  ████  █\r\n                                                                  ");
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
        }
        private void Rules()
        {
            Console.WriteLine();
            Console.WriteLine("You and I will have 7 dice at our disposal:");
            Console.WriteLine("D4 / D6 / D8 / D10 / D12 / D20 / D100");
            Console.WriteLine();
            Console.WriteLine("Each round we will choose a die and roll that same die 3 times, adding the results of each roll, whoever gets the highest number wins a point, do know you and I can pick different die to use.");
            Console.WriteLine("The turns will be determined at the start of the first round, setting the turns for all the rounds.");
            Console.WriteLine("But! If the result is a tie the die will be rerolled.");
            Console.WriteLine("Be aware that once a die is used it will disappear never to be seen again.");
        }
    }
}