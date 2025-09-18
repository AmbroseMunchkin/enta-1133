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
            Intro();
            GameLoop();
            Outro();
        }
        public static void Intro()
        {
            Console.WriteLine("Welcome to Dice Rolling! My name is Arlet Alcaraz and today is 18 of september 2025");
            Console.WriteLine("");
        }
        public static void GameLoop()
        {

        }
        public static void Outro()
        {
            Console.WriteLine("(+): Adds two values, for example 1 + 5 = 6)");
            Console.WriteLine("(-): Substracts one value from another, for example 7 - 4 = 3"); //From line 28 to line 31 its common operations that i didn't need to find the explanation
            Console.WriteLine("(/): Divides one value by another, for example 20 / 5 = 4)");
            Console.WriteLine("(*): Multiplies two values, for example 5 * 7 = 35)"); 
            Console.WriteLine("(++): Increases the value of a variable by 1, for example z = 7, so z++ = 8)"); //We saw this one in class
            Console.WriteLine("(--): Decreases the value of a variable by 1, for example w = 16, so w-- = 15)"); //Pretty much the same reasoning of the ++ we saw in class
            Console.WriteLine("(%): Returns the remainder of a division operation, for example 17 + 5 = 2)"); //Still confused about this one so ill ask later in class
            Console.WriteLine("");
            Console.WriteLine("Thanks for giving this a try! Have a wonderful day!");
        }
    }
}
