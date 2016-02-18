using System;

namespace NoughtsAndCrosses
{
    class Game
    {
        public IBoardCommunication interpreter;
        public Game(IBoardCommunication interpreter)
        {
            this.interpreter = interpreter;
        }

        public void GameLoop(Player player1, Player player2, GameBoard board)
        {
            bool gameOver = false;
            Player currentPlayer = player1;
            while (!gameOver)
            {
                MakeMove(board, currentPlayer);
                gameOver = GameIsOver(board, currentPlayer);
                interpreter.ShowBoard(board);
                if (gameOver) break;
                currentPlayer = ChangePlayer(currentPlayer, player1, player2);
            }
            interpreter.ShowGameResult(board, currentPlayer);
        }

        private Player ChangePlayer(Player currentPlayer, Player player1, Player player2)
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

        private void MakeMove(GameBoard board, Player player) 
        {
            Position coordinates;
            coordinates = interpreter.GetPlayerInput();
            while (!board.CoordinatesAreValid(coordinates))
            {
                //interpreter
                coordinates = interpreter.GetPlayerInput();
            }
            board.MarkPlayerTurn(player, coordinates);
        }

        private static bool GameIsOver(GameBoard board, Player player)
        {
            return(board.PlayerWon(player) || board.BoardIsFull());
        }
    }
}
