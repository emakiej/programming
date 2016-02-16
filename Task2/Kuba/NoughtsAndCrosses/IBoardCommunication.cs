namespace NoughtsAndCrosses
{
    interface IBoardCommunication
    {
        void ShowTheBoard(GameBoard board);
        void ShowGameResult(GameBoard board, Player player);
        Position GetPlayerInput();
    }
}
