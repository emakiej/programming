namespace NoughtsAndCrossesWPF
{
    public class Position
    {
        public int Horizontal { get; set; }
        public int Vertical { get; set; }

        public Position(int horizontal, int vertical)
        {
            this.Horizontal = horizontal;
            this.Vertical = vertical;
        }
    }
}