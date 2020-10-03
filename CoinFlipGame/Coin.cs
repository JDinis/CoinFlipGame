using System;
using System.Collections.Generic;
using System.Text;

namespace CoinFlipGame
{
    public static class Coin
    {
        public static readonly CoinFace Heads = new CoinFace(true);
        public static readonly CoinFace Tails = new CoinFace(false);
    }
}
