using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Implementations;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Repository
{
    public class IGameFactory
    {



        public static IGameInterface CreateGame(string gameType)
        {
            bool validInput = false;
            IGameInterface result = new Game();
            while (!validInput)
            {
                switch (gameType.ToUpper())
                {
                    case "T":
                        result = new Game();
                        validInput = true;
                        break;

                    case "N":
                        result = new AlternateGame();
                        validInput = true;
                        break;

                    default:
                        validInput = false;
                        Console.WriteLine("Invalid entry, would you like to play a (t)raditional game or the (n)ew one?");
                        gameType = Console.ReadLine();
                        break;
                }
            }
            return result;
        }



        public static Player CreatePlayer(string playerType)
        {
            bool validInput2 = false;
            Player result = new HumanPlayer("Player2");
            while (!validInput2)
            {
                switch (playerType.ToUpper())
                {
                    case "H":
                        result = new HumanPlayer("Player2");
                        validInput2 = true;
                        break;

                    case "C":
                        result = new ComputerPlayer("Player2");
                        validInput2 = true;
                        break;

                    case "W":
                        result = new WeightedComputerPlayer("Player2");
                        validInput2 = true;
                        break;

                    default:
                        validInput2 = false;
                        Console.WriteLine(
                            "Invalid entry, would you like to play against a (h)uman player, (c)omputer player, or (w)eighted computer player?");
                        playerType = Console.ReadLine();
                        break;
                }
            }
            return result;
        }
    }
}
