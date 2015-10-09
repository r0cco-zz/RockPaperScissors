using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Implementations
{
    class HumanPlayerSpock : Player
    {
        public HumanPlayerSpock(string Name) : base(Name)
        {
        }

        public override Choice GetChoice()
        {
            Choice choice = Choice.Unknown;

            while (choice == Choice.Unknown)
            {
                Console.Write("{0}, enter a choice: (R)ock, (P)aper, (S)cissors, (SP)ock, (L)izard : ", Name);
                string input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "R":
                        choice = Choice.Rock;
                        break;

                    case "P":
                        choice = Choice.Paper;
                        break;

                    case "S":
                        choice = Choice.Scissors;
                        break;

                    case "SP":
                        choice = Choice.Spock;
                        break;

                    case "L":
                        choice = Choice.Lizard;
                        break;


                    default:
                        Console.WriteLine("Invalid entry, please try again");
                        choice = Choice.Unknown;
                        break;
                }
            }

            return choice;
        }
    }
}
