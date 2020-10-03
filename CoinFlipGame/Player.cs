using System;
using System.Collections.Generic;
using System.Text;

namespace CoinFlipGame
{
    #nullable enable
    public class Player
    {
        public string Name { get; private set; }
        public CoinFace Choice { get; private set; } 

        public Player(string name, Player? rival = null)
        {
            Name = name;
            Choice = GetOppositeChoice(rival);
        }

        private CoinFace GetOppositeChoice(Player? player)
        {
            if (player is null)
            {
                ChooseCoinFace();
                return Choice;
            }
            else
            {
                return player.Choice.Equals(Coin.Heads) ? Coin.Tails : Coin.Heads;
            }
        }

        internal void SetChoice(CoinFace face)
            => Choice = face;

        private void ChooseCoinFace()
            => Choice = ChoiceResult() ? Coin.Heads : Coin.Tails;

        private bool ChoiceResult()
            => (DateTime.Now.Ticks & 1) == 1;
    }
    #nullable disable
}
