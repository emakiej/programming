namespace NoughtsAndCrossesWPF
{
    public class Player
    {
        public string name;
        public GameBoardStatus choosenSymbol;

        public Player(GameBoardStatus symbol, string name)
        {
            this.choosenSymbol = symbol;
            this.name = name;
        }        
    }
}