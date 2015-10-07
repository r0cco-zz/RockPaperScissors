using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors
{
    public class Game : IGameInterface
    {
        public void PlayRound(Player player2)
        {
            Player p1 = new HumanPlayer("Player1");
            Player p2 = player2;
            string input = "";

            do
            {
                MatchResult result = new MatchResult();
            result.Player1_Choice = p1.GetChoice();
            result.Player2_Choice = p2.GetChoice();     
  
                if (result.Player1_Choice == result.Player2_Choice)
            {
                result.Match_Result = Result.Tie;
            }
            else if ((result.Player1_Choice == Choice.Rock && (result.Player2_Choice == Choice.Scissors))  ||
                     (result.Player1_Choice == Choice.Paper && (result.Player2_Choice == Choice.Rock))  ||
                     (result.Player1_Choice == Choice.Scissors && (result.Player2_Choice == Choice.Paper))  ||
                     (result.Player1_Choice == Choice.Spock && (result.Player2_Choice == Choice.Rock)))
            {
                result.Match_Result = Result.Win;
            }
            else
            {
                result.Match_Result = Result.Loss;
            }

            ProcessResult(p1, p2, result);                

                Console.Write("\nWould you like to play again? (Enter \"Q\" to quit) : ");
                input = Console.ReadLine();
            } while (input.ToUpper() != "Q");


        }
        int player1Wins = 0;
        int player2Wins = 0;
        int player1Losses = 0;
        int player2Losses = 0;
        int playerTies = 0;
        public void ProcessResult(Player Player1, Player Player2, MatchResult Result)
        {
            Console.WriteLine("\n{0} picked {1}, {2} picked {3}", Player1.Name,
                Enum.GetName(typeof (Choice), Result.Player1_Choice), Player2.Name,
                Enum.GetName(typeof (Choice), Result.Player2_Choice));
           


            switch (Result.Match_Result)
            {
                case Enums.Result.Win:
                    Console.WriteLine("\n{0} wins!!", Player1.Name);
                    player1Wins ++;
                    player2Losses ++;
                    break;

                case Enums.Result.Loss:
                    Console.WriteLine("\n{0} wins!!", Player2.Name);
                    player2Wins ++;
                    player1Losses ++;
                    break;

                default:
                    Console.WriteLine("\nYou both tie!!");
                    playerTies ++;
                    break;
            }

            Console.WriteLine("{0}'s wins: {1}", Player1.Name, player1Wins);
            Console.WriteLine("{0}'s wins {1}", Player2.Name, player2Wins);
            Console.WriteLine("Ties: {0}", playerTies);
        }

       
       

        
    }
}
