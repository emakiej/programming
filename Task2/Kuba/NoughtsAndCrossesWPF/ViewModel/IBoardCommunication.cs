namespace NoughtsAndCrossesWPF
{
    public interface IBoardCommunication
    {
        //void ShowBoard(GameBoard board);
        void ShowGameResult(GameBoard board, Player player, GameStatus gameStatus);
        Position GetPlayerInput(object coordinatesRepresentation);
    }
}
