using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Implementations;

namespace RockPaperScissors.Interfaces
{
    public interface IGameInterface
    {
        void PlayRound( Player player2 );
    }
}
