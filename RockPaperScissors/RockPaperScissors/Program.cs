using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, Paper, Scissors!!");

            Game newGame = new Game();

            string input = "";
            do
            {
                newGame.PlayRound();

                Console.Write("\nWould you like to play again? (Enter \"Q\" to quit) : ");
                input = Console.ReadLine();
            } while (input.ToUpper() != "Q");

            Console.ReadLine();
        }
    }
}
