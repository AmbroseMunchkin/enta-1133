using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class DieRoller
    {
        public static void PlayerStart()
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

            Console.WriteLine("Pick your dice!");
            Console.WriteLine("1.- D4 , 2.- D6, 3.- D8 , 4.- D12, 5.- D20");
            Console.WriteLine();
            Console.WriteLine("Type your option");
            string choiceInput = Console.ReadLine();                        //ChoiceInput will determine what dice will be used 
            if (choiceInput == "1")
            {
                Console.WriteLine();
                Console.WriteLine("You choose a D4");
                Console.WriteLine("It landed in a " + die4 + "!");
                playertotal = die4;
            }
            else if (choiceInput == "2")
            {
                Console.WriteLine();
                Console.WriteLine("You choose a D6");
                Console.WriteLine("It landed in a " + die6 + "!");
                playertotal = die6;
            }
            else if (choiceInput == "3")
            {
                Console.WriteLine();
                Console.WriteLine("You choose a D8");
                Console.WriteLine("It landed in a " + die8 + "!");
                playertotal = die8;
            }
            else if (choiceInput == "4")
            {
                Console.WriteLine();
                Console.WriteLine("You choose a D12");
                Console.WriteLine("It landed in a " + die12 + "!");
                playertotal = die12;
            }
            else if (choiceInput == "5")
            {
                Console.WriteLine();
                Console.WriteLine("You choose a D20");
                Console.WriteLine("It landed in a " + die20 + "!");
                playertotal = die20;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid choice, using the d6 as default");
                Console.WriteLine("It landed in a " + die6 + "!");
                playertotal = die6;
            }
            Console.WriteLine();
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
                PlayerStart();
            }
            Console.WriteLine();
            Console.WriteLine("The score is--> Player: " + playerscore + " Computer: " + computerscore);
        }
        public static void ComputerRolls() //It was easier for me to have the dice rolling for the player and the computer in different public voids
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
            Console.WriteLine("It's your turn! Pick your dice!");
            Console.WriteLine("1.- D4 , 2.- D6, 3.- D8 , 4.- D12, 5.- D20");            //Pretty much the same as the player starts, just switching positions, i tried to make everything more optimized
            Console.WriteLine();
            Console.WriteLine("Type your option");
            string choiceInput = Console.ReadLine();
            if (choiceInput == "1")
            {
                Console.WriteLine();
                Console.WriteLine("You choose a D4");
                Console.WriteLine("It landed in a " + die4 + "!");
                playertotal = die4;
            }
            else if (choiceInput == "2")
            {
                Console.WriteLine();
                Console.WriteLine("You choose a D6");
                Console.WriteLine("It landed in a " + die6 + "!");
                playertotal = die6;
            }
            else if (choiceInput == "3")
            {
                Console.WriteLine();
                Console.WriteLine("You choose a D8");
                Console.WriteLine("It landed in a " + die8 + "!");
                playertotal = die8;
            }
            else if (choiceInput == "4")
            {
                Console.WriteLine();
                Console.WriteLine("You choose a D12");
                Console.WriteLine("It landed in a " + die12 + "!");
                playertotal = die12;
            }
            else if (choiceInput == "5")
            {
                Console.WriteLine();
                Console.WriteLine("You choose a D20");
                Console.WriteLine("It landed in a " + die20 + "!");
                playertotal = die20;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid choice, using the d6 as default");
                Console.WriteLine("It landed in a " + die6 + "!");
                playertotal = die6;
            }

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
                PlayerStart();                                                              //Used a lot of if and else, but it was the only way i could make it work
            }
            Console.WriteLine();
            Console.WriteLine("The score is--> Player: " + playerscore + " Computer: " + computerscore);
        } 
    }
}
