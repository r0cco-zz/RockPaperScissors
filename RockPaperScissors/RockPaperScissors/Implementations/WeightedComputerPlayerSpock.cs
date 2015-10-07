using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Implementations
{
    class WeightedComputerPlayerSpock : Player
    {
        private static Random _randomGenerator = new Random();

        public WeightedComputerPlayerSpock(string Name) : base(Name)
        {

        }

        public override Choice GetChoice()
        {
            int i = _randomGenerator.Next(1, 13);
            Choice choice = Choice.Unknown;

            switch (i)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:

                    choice = Choice.Rock;
                    break;

                case 8:
                case 9:

                    choice = Choice.Scissors;
                    break;

                case 10:

                    choice = Choice.Paper;
                    break;

                case 11:

                    choice = Choice.Spock;
                    break;

                case 12:

                    choice = Choice.Lizard;
                    break;


            }


            return (choice);
        }
    }
}
