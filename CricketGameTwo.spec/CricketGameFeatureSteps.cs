using System;
using TechTalk.SpecFlow;
using CricketGameTwoPlayers;
using FluentAssertions;

namespace CricketGameTwo.spec
{
    [Binding]
    public class CricketGameFeatureSteps
    {
        private CricketGameMainClass _person1;
        private CricketGameMainClass _person2;

        [Given(@"player1 starts the game with initial score as  (.*)")]
        public void GivenPlayerStartsTheGameWithInitialScoreAs(int p1)
        {
            _person1=new CricketGameMainClass();
            _person1.Player_1_Initial_score(p1);

        }
        
        [Given(@"player1 scores (.*) runs")]
        public void GivenPlayerScoresRuns(int p1)
        {
            _person1.Player_1_Incrimental_Score(p1);
        }
        
        [Given(@"player1 gets out")]
        public void GivenPlayerGetsOut()
        {
            _person1.player_1_Total_Score();
        }
        
        [Given(@"player1 total scores is (.*)")]
        public void GivenPlayerTotalScoresIs(int p1)
        {
            _person1.player_1_Total_Score();
        }
        [Given(@"player2 starts the game with initial score as  (.*)")]
        public void GivenPlayer2StartsTheGameWithInitialScoreAs(int p1)
        {
            _person2 = new CricketGameMainClass();
            _person2.player_2_Initial_score(p1);
        }
        [Given(@"player2 scores (.*) runs")]
        public void GivenPlayer2ScoresRuns(int p1)
        {
            _person2.Player_2_Incrimental_Score(p1);
        }
        [Given(@"player2 gets out")]
        public void GivenPlayer2GetsOut()
        {
            _person2.player_2_Total_Score();
        }
        [Given(@"player2 total scores is (.*)")]
        public void GivenPlayer2TotalScoresIs(int p1)
        {
            _person2.player_2_Total_Score();
        }
        [When(@"player1 scores is greater than player2 score")]
        public void WhenPlayer1ScoresIsGreaterThanPlayer2Score()
        {
            _person1.player_1_wins();
        }
        [When(@"player2 scores is greater than player1 score")]
        public void WhenPlayer2ScoresIsGreaterThanPlayer1Score()
        {
            _person2.player_2_wins();
        }

        [Then(@"player1 wins set (.*)")]
        public void ThenPlayer1Wins(int num)
        {
            _person1.win.Should().Be(num);
        }
        [Then(@"player2 wins set (.*)")]
        public void ThenPlayer2Wins(int num)
        {
            _person2.win.Should().Be(num);
        }
        [When(@"player2 scores is equal to player1 score")]
        public void Whenplayer2scoresisequaltoplayer1score()
        {
            _person1.player_1_wins();
            _person2.player_2_wins();
        }
        [Then(@"There should be a Tie")]
        public void ThenThereShouldBeATie()
        {
            _person1.win.Should().Be(_person2.win);
        }



    }
}
