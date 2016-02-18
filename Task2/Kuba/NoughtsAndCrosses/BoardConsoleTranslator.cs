using System;

namespace NoughtsAndCrosses
{
    class BoardConsoleTranslator :IBoardCommunication
    {
        public void ShowBoard(GameBoard board)
        {
            for (int i = 0; i < board.boardSize; i++)
            {
                for (int j = 0; j < board.boardSize; j++)
                {
                    Console.Write(TranslateStatus(board.gameBoard[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
        }

        public String TranslateStatus(GameBoardStatus status)
        {
            if (status == GameBoardStatus.nought) return "|O|";
            if (status == GameBoardStatus.cross) return "|X|";
            else return "| |";
        }

        /*public Position AskForCoordinatesUntilValid(GameBoard board)
        {
            Position coordinates = new Position();
            coordinates = GetPlayerInput();
            while (!board.CoordinatesAreValid(coordinates))
            {
                Console.WriteLine("Coordinates not valid!");
                coordinates = GetPlayerInput();
            }
            return coordinates;
        }*/

        public Position GetPlayerInput() //is the name descriptive enough?
        {
            Position coordinates = new Position();
            int indexDifference = 1;
            coordinates.Vertical = ForceIntInput("vertical") - indexDifference;
            coordinates.Horizontal = ForceIntInput("horizontal") - indexDifference;
            return coordinates;
        }

        private int ForceIntInput(string VerticalOrHorizontal)
        {
            Console.WriteLine("Choose " + VerticalOrHorizontal + " position (1-3):");
            int coordinate = 0;
            int.TryParse(Console.ReadLine(), out coordinate);
            return coordinate;
        }

        public void ShowGameResult(GameBoard board, Player player)
        {
            if (board.PlayerWon(player))
            {
                Console.WriteLine(player.Name + " won!");
            }
            else if (board.BoardIsFull())
            {
                Console.WriteLine("Tie!");
            }
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to Nougths And Crosses!");
        }

        public string GetPlayerName(int playerIndex, GameBoardStatus symbol)
        {
            Console.WriteLine("Player " + playerIndex.ToString() + " will play with " + symbol + ". Type player name:");
            string name = Console.ReadLine();
            return name;
        }

        public void NotifyCoordinatesInvalid()
        {
            Console.WriteLine("Coordinates not valid! Please, retry.");
        }
    }
}
