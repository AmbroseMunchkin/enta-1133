using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class DieRoller
    {
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
            Console.WriteLine();
            Console.WriteLine($"Your total is: {d6 + d8 + d12 + d20}");
            Console.WriteLine();
        }
    }
}
