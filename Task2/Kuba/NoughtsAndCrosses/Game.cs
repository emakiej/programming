using System;

namespace NoughtsAndCrosses
{
    class Game
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
            GameLoop(player1, player2, board);

            Console.ReadLine();
        }

        private static void GameLoop(Player player1, Player player2, GameBoard board)
        {
            BoardConsoleTranslator consoleInterpreter = new BoardConsoleTranslator();
            bool gameOver = false;
            while (!gameOver)
            {
                MakeMove(board, player1);
                gameOver = GameIsOver(board, player1);
                consoleInterpreter.PrintToConsole(board);
                if (gameOver) break;

                MakeMove(board, player2);
                gameOver = GameIsOver(board, player2);
                consoleInterpreter.PrintToConsole(board);
                if (gameOver) break;
            }
        }

        private static void MakeMove(GameBoard board, Player player)
        {
            Position coordinates = new Position();
            BoardConsoleTranslator consoleInterpreter = new BoardConsoleTranslator();
            coordinates = consoleInterpreter.AskForCoordinatesUntilValid(board);
            board.MarkPlayerTurn(player, coordinates);
        }

        private static bool GameIsOver(GameBoard board, Player player)
        {
            BoardConsoleTranslator consolePrinter = new BoardConsoleTranslator();
            if (board.PlayerWon(player))
            {
                Console.WriteLine(player.Name + " won!");
                return true;
            }
            else if (board.BoardIsFull())
            {
                Console.WriteLine("Tie!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
