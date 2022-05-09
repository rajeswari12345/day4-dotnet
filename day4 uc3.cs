// See https://aka.ms/new-console-template for more information
using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;
  
namespace Snake_Ladder
{
    class Gameuc3
    {
        public static void player()
        {
            int player_position = 0;

            Random random = new Random();
            int DiceRolled = random.Next(1, 7);
            Console.WriteLine("DiceRolled : (0) ", DiceRolled);

            int computerChoice = random.Next(0, 5);
            Console.WriteLine("Dice value :" + computerChoice);

            switch (computerChoice)
            {
                case 0:
                    Console.WriteLine(" No play");
                    break;
                case 1:
                    player_position = player_position + DiceRolled; // Moving forward
                    Console.WriteLine(" Get Ladder");
                    break;
                case 2:
                    player_position = player_position - DiceRolled; // Move back
                    Console.WriteLine(" Snake  Ladder");
                    break;

                default:
                    Console.WriteLine(" invaid option");
                    break;
            }
        }
    }



}



