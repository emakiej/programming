using System;

namespace NoughtsAndCrosses
{
    public class GameBoard
    {
        public readonly int boardSize = 3; //Kuba: czy lepsze byłoby pole statyczne?
        public GameBoardStatus[,] gameBoard;

        public GameBoard()
        {
            gameBoard = new GameBoardStatus[boardSize, boardSize];
        }

        public void MarkPlayerTurn(Player player, Position coordinates)
        {
            if (CoordinatesAreValid(coordinates))
            {
                this.gameBoard[coordinates.Vertical, coordinates.Horizontal] = player.ChoosenSymbol;
            }
        }

        public bool BoardIsFull()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (this.gameBoard[i, j] == GameBoardStatus.empty) return false;
                }
            }
            return true;
        }

        public bool PlayerWon(Player player)
        {
            return (CheckVertically(player) || CheckHorizontally(player) || CheckDiagonally(player));
        }

        private bool CheckVertically(Player player)
        {
            for (int i = 0; i < boardSize; i++)
            {
                int playerSymbolCount = 0;
                for (int j = 0; j < boardSize; j++)
                {
                    if (this.gameBoard[j, i] == player.ChoosenSymbol)
                    {
                        playerSymbolCount++;
                    }
                }
                if (playerSymbolCount == boardSize)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckHorizontally(Player player)
        {
            for (int i = 0; i < boardSize; i++)
            {
                int playerSymbolCount = 0;
                for (int j = 0; j < boardSize; j++)
                {
                    if (this.gameBoard[i, j] == player.ChoosenSymbol)
                    {
                        playerSymbolCount++;
                    }
                }
                if (playerSymbolCount == boardSize)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckDiagonally(Player player)
        {
            int playerSymbolCount = 0;
            for (int i = 0; i < boardSize; i++)
            {
                if (this.gameBoard[i, i] == player.ChoosenSymbol)
                {
                    playerSymbolCount++;
                }
            }
            if (playerSymbolCount == boardSize)
            {
                return true;
            }
            else
            {
                playerSymbolCount = 0;
            }

            for (int i = 0; i < boardSize; i++)
            {
                if (this.gameBoard[i, (boardSize - 1) - i] == player.ChoosenSymbol)
                {
                    playerSymbolCount++;
                }
            }
            if (playerSymbolCount == boardSize)
            {
                return true;
            }
            return false;
        }

        public bool CoordinatesAreValid(Position coordinates)
        {
            return (CoordinatesInRange(coordinates) && PositionNotTaken(coordinates));
        }

        private bool CoordinatesInRange(Position coordinates)
        {
            return (coordinates.Vertical < boardSize && coordinates.Horizontal < boardSize &&
                    coordinates.Vertical >= 0 && coordinates.Horizontal >= 0);
        }

        private bool PositionNotTaken(Position coordinates)
        {
            return (gameBoard[coordinates.Vertical, coordinates.Horizontal] == GameBoardStatus.empty);
        }
    }
}