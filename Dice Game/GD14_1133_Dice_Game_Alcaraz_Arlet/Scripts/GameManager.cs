using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class GameManager
    {
        private List<Player> turnOrder = new List<Player>();  //Declared the players first so i can access it in every function
        Player player = new Player();
        Player cpu = new Player();
        DieRoller roller = new DieRoller();
        int playerscore = 0;
        int cpuscore = 0;
        
        public void ProgramStart()
        {
            cpu.username = "Arlet";
            Intro();
            player.User(); //Fixed how the intro is since it was rude to start by asking the player name
            Rules();     //Added the rules as its own private void since i will only call it once
            player.Initialize();
            cpu.Initialize();
            DecideTurnOrder();
            RoundLoop();
            Outro();
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
            Console.WriteLine("Each round we will choose a die and roll that same die 3 times, adding the results of each roll, \nwhoever gets the highest number wins a point, do know you and I can pick different die to use.");
            Console.WriteLine("The turns will be determined at the start of the first round, setting the turns for all the rounds.");
            Console.WriteLine("But! If the result is a tie the die will be rerolled.");
            Console.WriteLine($"Be aware " + player.username + " that once a die is used it will disappear never to be seen again.\n");
        }

        private void DecideTurnOrder()
        {
            Console.WriteLine("Let's decide who starts:\n");

            Random coinRandom = new Random();
            int coinResult = coinRandom.Next(0, 2);
            if (coinResult == 0)
            {
                //Player starts
                turnOrder.Add(player);
                turnOrder.Add(cpu);
            }
            else
            {
                //Cpu starts
                turnOrder.Add(cpu);
                turnOrder.Add(player);
            }
            Console.WriteLine(turnOrder[0].username + " starts!");
        }
        private int TakingTurn(Player player, string die)
        {
            int numFaces = player.availableDice[die];
            int rollerResult = 0;
            string singularResults = player.username + " grabs the " + die + " and rolls it 3 times, the results are:";

            for (int i = 0; i < 3; i++)
            {
                int thisRolle = roller.RollDice(numFaces);
                rollerResult += thisRolle;
                singularResults += " " + thisRolle + ",";
            }
            Console.WriteLine(singularResults);
            player.availableDice.Remove(die);
            return rollerResult;
        }
        private void RoundLoop()
        {
            int cpuRollerResults = 0;
            int playerRollerResult = 0;
            while (turnOrder[0].availableDice.Count > 0)
            {
                for (int i = 0; i < turnOrder.Count; i++)
                {
                    Player player = turnOrder[i];
                    int rollerResults;
                    string playerChoice;
                    if (player == cpu)
                    {
                        playerChoice = player.CPUChoice();
                        rollerResults = TakingTurn(player, playerChoice);
                        cpuRollerResults = rollerResults;
                    }
                    else
                    {
                        playerChoice = player.PlayerChoice();
                        rollerResults = TakingTurn(player, playerChoice);
                        playerRollerResult = rollerResults;
                    }
                }
                Console.WriteLine("The final sum is:");
                Console.WriteLine(player.username + "--> " + playerRollerResult);
                Console.WriteLine(cpu.username + "--> " + cpuRollerResults);
                Console.WriteLine();
                if (cpuRollerResults > playerRollerResult)
                {
                    Console.WriteLine(cpu.username + " wins a point!");
                    cpuscore++;
                }
                else
                {
                    Console.WriteLine(player.username + " wins a point!");
                    playerscore++;
                }
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            }

            Console.WriteLine("The score is: CPU: " + cpuscore + "PLAYER: " + playerscore);
        }
    }
}