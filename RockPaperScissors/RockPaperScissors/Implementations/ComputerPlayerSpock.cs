using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Implementations
{
    class ComputerPlayerSpock : Player
    {
        private static Random _randomGenerator = new Random();

        public ComputerPlayerSpock(string Name) : base(Name)
        {
        }

        public override Choice GetChoice()
        {
            int i = _randomGenerator.Next(1, 6);

            return (Choice)i;
        }
    }
}
