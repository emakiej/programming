using System;

namespace NoughtsAndCrosses
{
    class Game
    {
        public void GameLoop(Player player1, Player player2, GameBoard board)
        {
            BoardConsoleTranslator consoleInterpreter = new BoardConsoleTranslator();
            bool gameOver = false;
            Player currentPlayer = player1;
            while (!gameOver)
            {
                MakeMove(board, currentPlayer);
                gameOver = GameIsOver(board, currentPlayer);
                consoleInterpreter.PrintToConsole(board);
                if (gameOver) break;
                currentPlayer = ChangePlayer(currentPlayer, player1, player2);
            }
        }

        private static Player ChangePlayer(Player currentPlayer, Player player1, Player player2)
        {
            if (currentPlayer == player1)
            {
                return player2;
            }
            else
            {
                return player1;
            }
        }

        private static void MakeMove(GameBoard board, Player player)
        {
            Position coordinates;
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
