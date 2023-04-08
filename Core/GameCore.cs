using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_GUI.Core
{
    internal class GameCore
    {
        private int rounds;
        private string winner;
        private string game_message;
        public GameCore() {
            rounds = 0;
            winner = "";
            game_message = "じゃんけん・・・";
        }

        public string whoWin(int player_decision, int com_decision)
        {
            int calculation = ((player_decision - com_decision) + 3) % 3;
            switch (calculation)
            {
                case 0:
                    winner = "引き分け";
                    break;
                case 1:
                    winner = "プレイヤー";
                    break;
                case 2:
                    winner = "COM";
                    break;
             }
            return winner;
        }

        public void addRound()
        {
            rounds++;
        }

        public void setMessage()
        {
            switch (winner)
            {
                case "引き分け":
                    game_message = "あいこで・・・";
                    break;
                case "プレイヤー":
                    game_message = "あなたの勝ち！";
                    break;
                case "COM":
                    game_message = "あなたの負け";
                    break;
            }
        }

        public string getMessage()
        {
            return game_message;
        }

        public void resetGame()
        {
            game_message = "じゃんけん・・・";
            winner = "";
        }

        public int getRound()
        {
            return rounds;
        }
    }
}
