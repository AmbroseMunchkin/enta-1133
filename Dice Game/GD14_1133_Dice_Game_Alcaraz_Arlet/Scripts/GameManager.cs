using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class GameManager
    {
        public static void ProgramStart()
        {
            Intro(); //Each one of this calls a process happening in this script
            RollOrDie();
            Outro();
        }
        private static void Intro()
        {
            Console.WriteLine("Welcome to Dice Rolling! My name is Arlet Alcaraz and today is 18 of september 2025");
            Console.WriteLine("Let's roll some dice! May the odds be ever in your favor");
            Console.WriteLine(); //Adding this ones so it looks more clean in the console output
        }
        private static void RollOrDie()
        {
            DieRoller.Rolls(); //Here i call the dice rolling script
        }
        private static void Outro()
        {
            Console.WriteLine("Now that we rolled the dice, here is the explanation of how the arithmetic operators work:"); //Mostly adding this so its clear where the dice rolling ends and the explanation starts
            Console.WriteLine("(+): Adds two values, for example 1 + 5 = 6)");
            Console.WriteLine("(-): Substracts one value from another, for example 7 - 4 = 3"); //From line 28 to line 31 its common operations that i didn't need to find the explanation
            Console.WriteLine("(/): Divides one value by another, for example 20 / 5 = 4)");
            Console.WriteLine("(*): Multiplies two values, for example 5 * 7 = 35)"); 
            Console.WriteLine("(++): Increases the value of a variable by 1, for example z = 7, so z++ = 8)"); //We saw this one in class
            Console.WriteLine("(--): Decreases the value of a variable by 1, for example w = 16, so w-- = 15)"); //Pretty much the same reasoning of the ++ we saw in class, just resting instead of adding
            Console.WriteLine("(%): Returns the remainder of a division operation, for example 17 + 5 = 2)"); //This one is a tricky one since we think is the percentage, but it's the remainder of the division
            Console.WriteLine();
            Console.WriteLine("Thanks for giving this a try! Have a wonderful day!");
        }
    }
}
