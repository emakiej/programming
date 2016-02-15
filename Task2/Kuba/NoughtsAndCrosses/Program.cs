using System;

namespace NoughtsAndCrosses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nougths And Crosses!");
            Player player1 = new Player();
            Player player2 = new Player();
            Console.WriteLine("Player 1 will play with noughts. Choose player 1 name:");
            player1.Name = Console.ReadLine();
            player1.ChoosenSymbol = GameBoardStatus.nought;
            Console.WriteLine("Player 2 will play with crosses. Choose player 2 name:");
            player2.Name = Console.ReadLine();
            player2.ChoosenSymbol = GameBoardStatus.cross;

            GameBoard board = new GameBoard();
            Game game = new Game();
            game.GameLoop(player1, player2, board);

            Console.ReadLine();
        }
    }
}
