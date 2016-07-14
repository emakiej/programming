using System;

namespace NoughtsAndCrossesWPF
{
    class Game
    {
        public IBoardCommunication interpreter;
        GameStatus gameStatus;
        public GameBoard board = new GameBoard();
        public Player player1 = new Player(GameBoardStatus.cross, "Crosses"); //TODO: implement player's name input box
        public Player player2 = new Player(GameBoardStatus.nought, "Noughts");
        public Player currentPlayer;

        public Game(IBoardCommunication interpreter)
        {
            this.interpreter = interpreter;
            currentPlayer = player1;
        }

        public void MakeTurn(object field)
        {
            MakeMove(field);
            gameStatus = GetGameStatus(board, currentPlayer);
            if (gameStatus != GameStatus.Active) 
            {
                interpreter.ShowGameResult(board, currentPlayer, gameStatus); 
            }
            currentPlayer = ChangePlayer();
        }

        public Player ChangePlayer()
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

        public void MakeMove(object field)
        {
            Position coordinates = interpreter.GetPlayerInput(field);
            if (!board.CoordinatesAreValid(coordinates))
            {
                coordinates = interpreter.GetPlayerInput(field);
            }
            board.MarkPlayerTurn(currentPlayer, coordinates);
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