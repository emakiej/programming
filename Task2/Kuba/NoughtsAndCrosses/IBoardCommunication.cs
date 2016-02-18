namespace NoughtsAndCrosses
{
    public interface IBoardCommunication
    {
        void ShowBoard(GameBoard board);
        void ShowGameResult(GameBoard board, Player player);
        Position GetPlayerInput();
    }
}
