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

        public void GameLoop(Player player1, Player player2)
        {
            GameBoard board = new GameBoard();
            GameStatus gameStatus = new GameStatus();
            Player currentPlayer = player2;
            while (gameStatus == GameStatus.Active)
            {
                currentPlayer = ChangePlayer(currentPlayer, player1, player2);
                MakeMove(board, currentPlayer);
                gameStatus = GetGameStatus(board, currentPlayer);
                interpreter.ShowBoard(board);
            }
            interpreter.ShowGameResult(board, currentPlayer, gameStatus);
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
            do
            {
                coordinates = interpreter.GetPlayerInput();
            }
            while (!board.CoordinatesAreValid(coordinates));
            board.MarkPlayerTurn(player, coordinates);
        }

        private GameStatus GetGameStatus(GameBoard board, Player player)
        {
            if (board.PlayerWon(player))
            {
                return GameStatus.PlayerWon;
            }
            else if (board.BoardIsFull())
            {
                return GameStatus.Tie;
            }
            return GameStatus.Active;
        }
    }
}
