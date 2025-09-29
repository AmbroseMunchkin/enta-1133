using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class DieRoller
    {
<<<<<<< Updated upstream
        public static void Rolls()
        {
            Random random = new Random();
            int d6 = random.Next(1, 7);
            int d8 = random.Next(1, 9); //Was struggling to get the random numbers working, until i saw i needed to open my public void so it could be called in the GameManager
            int d12 = random.Next(1, 13);
            int d20 = random.Next(1, 21);

            Console.WriteLine($"Your d6 landed in: {d6}");
            Console.WriteLine($"Your d8 landed in: {d8}"); 
            Console.WriteLine($"Your d12 landed in: {d12}");
            Console.WriteLine($"Your d20 landed in: {d20}");
=======
        public static void PlayerStart(Player player)
        {
            Random random = new Random();
            int die4 = random.Next(1, 5);
            int die6 = random.Next(1, 7);
            int die8 = random.Next(1, 9); 
            int die12 = random.Next(1, 13);
            int die20 = random.Next(1, 21);
            int playertotal = 0;
            int computertotal = 0;
            int playerscore = 0;
            int computerscore = 0;
            Console.WriteLine(player.Name);
            Console.WriteLine("Pick your dice!");
            Console.WriteLine("1.- D4 , 2.- D6, 3.- D8 , 4.- D12, 5.- D20");
>>>>>>> Stashed changes
            Console.WriteLine();
            Console.WriteLine($"Your total is: {d6 + d8 + d12 + d20}");
            Console.WriteLine();
<<<<<<< Updated upstream
=======
            Console.WriteLine("It's the computer turn!");
            Random random1 = new Random();
            int randomdice = random1.Next(1, 6);
            if (randomdice == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Computer choose a D4 and got " + die4);
                computertotal = die4;
            }
            else if (randomdice == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Computer choose a D6 and got " + die6);
                computertotal = die6;
            }
            else if (randomdice == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Computer choose a D8 and got " + die8);
                computertotal = die8;
            }
            else if (randomdice == 4)
            {
                Console.WriteLine();
                Console.WriteLine("Computer choose a D12 and got " + die12);
                computertotal = die12;
            }
            else if (randomdice == 5)
            {
                Console.WriteLine();
                Console.WriteLine("Computer choose a D20 and got " + die20);
                computertotal = die20;
            }
            Console.WriteLine();
            if (computertotal > playertotal)
            {
                Console.WriteLine();
                Console.WriteLine("The computer wins!!!");
                computerscore = +1;
            }
            else if (computertotal < playertotal)
            {
                Console.WriteLine();
                Console.WriteLine("You won!!!");
                playerscore = +1;
            }
            else if (computertotal == playertotal)
            {
                Console.WriteLine();
                Console.WriteLine("It's a tie! Re-rolling time it is!");
                PlayerStart(player);
            }
            Console.WriteLine();
            Console.WriteLine("The score is--> Player: " + playerscore + " Computer: " + computerscore);
>>>>>>> Stashed changes
        }
    }
}
