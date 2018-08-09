using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGameTwoPlayers
{
    public class CricketGameMainClass
    {
        public int player1 { get; set; }
        public int player2 { get; set; }
        public int TotalScore1 { get; set; }
        public int TotalScore2 { get; set; }
        //public int win1 { get; set; }
        //public int win2 { get; set; }
        public int win = 0;
        public void Player_1_Initial_score(int zero)
        {
            player1 = zero;        
        }
        public void player_2_Initial_score(int zero)
        {
            player2 = zero;
        }
        public void  Player_1_Incrimental_Score(int runs)
        {
            player1 = player1 + runs;
        }
        public void Player_2_Incrimental_Score(int runs)
        {
            player2 = player2 + runs;
        }
        public void player_1_Total_Score()
        {
            TotalScore1 = player1;
        }
        public void player_2_Total_Score()
        {
            TotalScore2 = player2;
        }
        public void player_1_wins()
        {
           win = 1;
        }
        public void player_2_wins()
        {
            win = 1;

        }




    }
}
