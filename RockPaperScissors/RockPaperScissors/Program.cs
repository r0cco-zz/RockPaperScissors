using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, Paper, Scissors!!");
            Console.WriteLine("Do you want to play the (T)raditional game OR the (N)ew version?");
            string gameType = Console.ReadLine();

            AlternateGame alternateGame = new AlternateGame(); 
            Game newGame = new Game();

            if (gameType == "T")
            {
                newGame.PlayRound();
            }

            else
            {
                alternateGame.PlayRound();
            }        
                    
        }
    }
}
