using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;

namespace UnitTests.TestPlayers
{
    class RockPlayer : Player
    {
        public RockPlayer(string Name) : base(Name)
            {

        }

        public override Choice GetChoice()
        {
            return Choice.Rock;
        }
    }
}
