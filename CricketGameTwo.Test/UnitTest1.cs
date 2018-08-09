using System;
using CricketGameTwoPlayers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGameTwo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void initialScoreOfPerson1_scenario1()
        {
            var game = new CricketGameMainClass();
            Assert.IsTrue(game.player1 == 0);

        }
        [TestMethod]
        public void initialScoreOfPerson2_scenario1()
        {
            var game = new CricketGameMainClass();
            Assert.IsTrue(game.player2 == 0);

        }
        [TestMethod]
        public void IncrementalScoreOfPerson1_scenario1()
        {
            var game = new CricketGameMainClass();
            game.Player_1_Incrimental_Score(4);
            Assert.IsTrue(game.player1 == 4);
        }
        [TestMethod]
        public void IncrementalScoreOfPerson2_scenario1()
        {
            var game = new CricketGameMainClass();
            game.Player_2_Incrimental_Score(1);
            Assert.IsTrue(game.player2 == 1);
        }
        public void initialScoreOfPerson1_scenario2()
        {
            var game = new CricketGameMainClass();
            Assert.IsTrue(game.player1 == 0);

        }
        [TestMethod]
        public void initialScoreOfPerson2_scenario2()
        {
            var game = new CricketGameMainClass();
            Assert.IsTrue(game.player2 == 0);

        }
        [TestMethod]
        public void IncrementalScoreOfPerson1_scenario2()
        {
            var game = new CricketGameMainClass();
            game.Player_1_Incrimental_Score(1);
            Assert.IsTrue(game.player1 == 1);
        }
        [TestMethod]
        public void IncrementalScoreOfPerson2_scenario2()
        {
            var game = new CricketGameMainClass();
            game.Player_2_Incrimental_Score(4);
            Assert.IsTrue(game.player2 == 4);
        }


    }
}
