using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors;
using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;

namespace RockPaperScissorsMethodTests
{
    public class TestGame
    {
        public Result PlayRound(Player player1, Player player2)
        {

            MatchResult result = new MatchResult();
            result.Player1_Choice = player1.GetChoice();
            result.Player2_Choice = player2.GetChoice();

            if (result.Player1_Choice == result.Player2_Choice)
            {
                result.Match_Result = Result.Tie;
                return Result.Tie;
            }
            else if ((result.Player1_Choice == Choice.Rock && result.Player2_Choice == Choice.Scissors) ||
                     (result.Player1_Choice == Choice.Paper && result.Player2_Choice == Choice.Rock) ||
                     (result.Player1_Choice == Choice.Scissors && result.Player2_Choice == Choice.Paper))
            {
                result.Match_Result = Result.Win;
                return Result.Win;
            }
            else
            {
                result.Match_Result = Result.Loss;
                return Result.Loss;
            }

        }

    }

}

