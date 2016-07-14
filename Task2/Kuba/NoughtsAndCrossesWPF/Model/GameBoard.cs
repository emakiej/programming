namespace NoughtsAndCrossesWPF
{
    public class GameBoard
    {
        public const int boardSize = 3;
        public GameBoardStatus[,] fields;

        public GameBoard()
        {
            fields = new GameBoardStatus[boardSize, boardSize];
        }

        public void MarkPlayerTurn(Player player, Position coordinates)
        {
            if (CoordinatesAreValid(coordinates))
            {
                this.fields[coordinates.Vertical, coordinates.Horizontal] = player.choosenSymbol;
            }
        }

        public bool BoardIsFull()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (this.fields[i, j] == GameBoardStatus.empty) return false;
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
            int playerHorizontalSymbolCount= 0;
            int playerVerticalSymbolCount = 0;
            for (int i = 0; i < boardSize; i++)
            {
                playerHorizontalSymbolCount = 0;
                playerVerticalSymbolCount = 0;
                for (int j = 0; j < boardSize; j++)
                {
                    if (this.fields[i, j] == player.choosenSymbol)
                    {
                        playerHorizontalSymbolCount++;
                    }
                    if (this.fields[j, i] == player.choosenSymbol)
                    {
                        playerVerticalSymbolCount++;
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
                if (this.fields[i, i] == player.choosenSymbol)
                {
                    playerDescendingSymbolCount++;
                }
                if (this.fields[i, (boardSize - 1) - i] == player.choosenSymbol)
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
            return (fields[coordinates.Vertical, coordinates.Horizontal] == GameBoardStatus.empty);
        }

        public void EmptyTheBoard()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    this.fields[i, j] = GameBoardStatus.empty;
                }
            }
        }
    }
}