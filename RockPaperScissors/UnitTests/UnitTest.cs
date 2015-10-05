using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RockPaperScissors;
using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;
using RockPaperScissorsMethodTests;
using UnitTests.TestPlayers;

namespace UnitTests
{
    [TestFixture]
    public class UnitTest
    {
        [TestCase(Choice.Paper, Result.Tie)]
        [TestCase(Choice.Rock, Result.Win)]
        [TestCase(Choice.Scissors, Result.Loss)]
        public void WinTest(Choice choice, Result expectedResult)
        {
            //Arrange

            TestGame testGame = new TestGame();
            PaperPlayer player1 = new PaperPlayer("PaperPlayer");
            Player player2;

            //Act

            switch (choice)
            {
                case Choice.Rock:
                player2 = new RockPlayer("rockplayer");
                break;
                case Choice.Paper:
                    player2 = new PaperPlayer("paperplayer");
                    break;
                default:
                    player2 = new ScissorPlayer("scissorsplayer");
                    break;
            }

            Result actual = testGame.PlayRound(player1, player2);
            
            
            //Assert
            Assert.AreEqual(actual, expectedResult);
        }

    }
}
