using System;
using System.Collections.Generic;
using System.Text;

namespace CoinFlipGame
{
    public class CoinFace
    {
        public bool Face { get; private set; }

        public CoinFace(bool isHeads) 
            => Face = isHeads;

        public override string ToString()
        {
            return Face ? "Heads" : "Tails";
        }
    }
}
