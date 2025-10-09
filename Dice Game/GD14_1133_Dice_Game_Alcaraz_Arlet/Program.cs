using GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            gameManager.ProgramStart();     //Here i am calling the game manager script so the program can start
        }
    }
}
