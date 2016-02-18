using System;

namespace NoughtsAndCrosses
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();
            BoardConsoleTranslator interpreter = new BoardConsoleTranslator();

            interpreter.Welcome();
            player1.Name = interpreter.GetPlayerName(1, GameBoardStatus.nought);
            player1.ChoosenSymbol = GameBoardStatus.nought;
            player2.Name = interpreter.GetPlayerName(2, GameBoardStatus.cross);
            player2.ChoosenSymbol = GameBoardStatus.cross;

            GameBoard board = new GameBoard();
            Game game = new Game(interpreter);
            game.GameLoop(player1, player2, board);

            Console.ReadLine();
        }
    }
}