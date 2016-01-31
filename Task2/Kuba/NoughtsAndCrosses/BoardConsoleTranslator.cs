using System;

namespace NoughtsAndCrosses
{
    class BoardConsoleTranslator
    {
        public void PrintToConsole(GameBoard board)
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

        private string TranslateStatus(GameBoardStatus status)
        {
            if (status == GameBoardStatus.nought) return "|O|";
            if (status == GameBoardStatus.cross) return "|X|";
            else return "| |";
        }

        public Position AskForCoordinatesUntilValid(GameBoard board)
        {
            Position coordinates = new Position();
            coordinates = TranslatePlayerInputIntoCoordinates();
            while (!board.CoordinatesAreValid(coordinates))
            {
                Console.WriteLine("Coordinates not valid!");
                coordinates = TranslatePlayerInputIntoCoordinates();
            }
            return coordinates;
        }

        private Position TranslatePlayerInputIntoCoordinates()
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
    }
}
