using System;

namespace CoinFlipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Tom");
            Player player2 = new Player("John");

            Game game = new Game();
            game.SetPlayer1(player1);
            game.SetPlayer2(player2);
            var winner = game.GetWinner();
            var loser = game.GetLoser();

            Console.WriteLine($"Winning Choice: {Game.WinningCoinFace}\n" +
                $"{winner.Name} is the winner becase he has choosen {winner.Choice}!\n" +
                $"{loser.Name} has lost because he has choosen {loser.Choice}!");

            Console.ReadKey();
        }
    }
}
