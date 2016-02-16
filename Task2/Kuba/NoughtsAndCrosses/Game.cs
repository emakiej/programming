using System;

namespace NoughtsAndCrosses
{
    class Game
    {
        public void GameLoop(Player player1, Player player2, GameBoard board)
        {
            BoardConsoleTranslator consoleInterpreter = new BoardConsoleTranslator(); //can't use consoleInterperter here - needs to be universal (dependency injection)
            bool gameOver = false;
            Player currentPlayer = player1;
            while (!gameOver)
            {
                MakeMove(board, currentPlayer);
                gameOver = GameIsOver(board, currentPlayer);
                consoleInterpreter.ShowTheBoard(board);
                if (gameOver) break;
                currentPlayer = ChangePlayer(currentPlayer, player1, player2);
            }
            consoleInterpreter.ShowGameResult(board, currentPlayer);
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
            BoardConsoleTranslator consoleInterpreter = new BoardConsoleTranslator(); //can't use consoleInterperter here - needs to be universal
            coordinates = consoleInterpreter.AskForCoordinatesUntilValid(board);
            board.MarkPlayerTurn(player, coordinates);
        }

        private static bool GameIsOver(GameBoard board, Player player)
        {
            return(board.PlayerWon(player) || board.BoardIsFull());
        }
    }
}
