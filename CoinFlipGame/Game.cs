using System;
using System.Collections.Generic;
using System.Text;

namespace CoinFlipGame
{
    public class Game
    {
        public static CoinFace WinningCoinFace { get; private set; }
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        public Game()
            => FlipCoin();

        public Player GetWinner()
        {
            ChangeMatchingCoins();
            return Player1.Choice == WinningCoinFace ? Player1 : Player2;
        }

        public Player GetLoser()
        {
            ChangeMatchingCoins();
            return Player1.Choice != WinningCoinFace ? Player1 : Player2;
        }

        ///<summary>Fixes the problem of forgetting to initialize player with a rival</summary>
        public void ChangeMatchingCoins() {
            if (Player1.Equals(Player2))
            {
                throw new Exception("Player 1 and Player 2 must be different players!");
            }

            if (Player2.Choice.Equals(Player1.Choice))
            {
                Player2.SetChoice(new CoinFace(!Player1.Choice.Face));
            }
        }

        public void SetPlayer1(Player player)
            => Player1 = player;

        public void SetPlayer2(Player player)
            => Player2 = player;

        public void FlipCoin()
            => WinningCoinFace = GameResult() ? Coin.Heads : Coin.Tails;

        private bool GameResult()
            => (DateTime.Now.Ticks & 1) == 1;
    }
}
