using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class DieRoller
    {

        public static void PlayerRolls()
        {
            Random random = new Random();
            int die4 = random.Next(1, 5);
            int die6 = random.Next(1, 7);
            int die8 = random.Next(1, 9); 
            int die12 = random.Next(1, 13);
            int die20 = random.Next(1, 21);

            Console.WriteLine("Pick your dice!");
            Console.WriteLine("You have a d4 / d6 / d8 / d12 / d20");
            Console.WriteLine();
            Console.WriteLine("Type the dice you want to use:");
            string choiceInput = Console.ReadLine();
            if (choiceInput == "d4")
            {
                Console.WriteLine("You chose a D4");
                Console.WriteLine("It landed in a " + die4 + "!");
            }
            else if (choiceInput == "d6")
            {
                Console.WriteLine("You chose a D6");
                Console.WriteLine("It landed in a " + die6 + "!");
            }
            else if (choiceInput == "d8")
            {
                Console.WriteLine("You chose a D8");
                Console.WriteLine("It landed in a " + die8 + "!");
            }
            else if (choiceInput == "d12")
            {
                Console.WriteLine("You chose a D12");
                Console.WriteLine("It landed in a " + die12 + "!");
            }
            else if (choiceInput == "d20")
            {
                Console.WriteLine("You chose a D20");
                Console.WriteLine("It landed in a " + die20 + "!");
            }
            else
            {
                Console.WriteLine("Invalid choice, using the d6 as default");
                Console.WriteLine("It landed in a " + die6 + "!");
            }
        }
        public static void ComputerRolls() //It was easier for me to have the dice rolling for the player and the computer in different public voids
        {
            Random random = new Random();
            int die4 = random.Next(1, 5);
            int die6 = random.Next(1, 7);
            int die8 = random.Next(1, 9);
            int die12 = random.Next(1, 13);
            int die20 = random.Next(1, 21);

            Console.WriteLine("Computer chose a D4 and got " + die4);
        }
    }
}
