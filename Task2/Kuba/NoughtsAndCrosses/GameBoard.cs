using System;

namespace NoughtsAndCrosses
{
    public class GameBoard
    {
        public static int boardSize = 3;
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
            return (CheckVerticallyAndHorizontally(player) || CheckDiagonally(player));
        }

        private bool CheckVerticallyAndHorizontally(Player player)
        {
            for (int i = 0; i < boardSize; i++)
            {
                int playerVerticalSymbolCount = 0;
                int playerHorizontalSymbolCount = 0;
                for (int j = 0; j < boardSize; j++)
                {
                    if (this.gameBoard[j, i] == player.ChoosenSymbol)
                    {
                        playerVerticalSymbolCount++;
                    }
                    else if (this.gameBoard[i, j] == player.ChoosenSymbol)
                    {
                        playerHorizontalSymbolCount++;
                    }
                }
                if (playerHorizontalSymbolCount == boardSize || playerVerticalSymbolCount == boardSize)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckDiagonally(Player player)
        {
            int playerAscendingSymbolCount = 0;
            int playerDescendingSymbolCount = 0;
            for (int i = 0; i < boardSize; i++)
            {
                if (this.gameBoard[i, i] == player.ChoosenSymbol)
                {
                    playerDescendingSymbolCount++;
                }
                if (this.gameBoard[i, (boardSize - 1) - i] == player.ChoosenSymbol)
                {
                    playerAscendingSymbolCount++;
                }
            }
            if (playerAscendingSymbolCount == boardSize || playerDescendingSymbolCount == boardSize)
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