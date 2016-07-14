using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrossesWPF
{
    class WPFBoardCommunication : IBoardCommunication
    {

        public Position GetPlayerInput(object coordinatesRepresentation)
        {
            int oneDimensionalPosition = Convert.ToInt32(coordinatesRepresentation);
            Position twoDimensionalPosition = TranslateOneDimensionalPosition(oneDimensionalPosition);
            return twoDimensionalPosition;
        }

        public Position TranslateOneDimensionalPosition(int oneDimensionalPosition)
        {
            int vertical = oneDimensionalPosition / 3;
            int horizontal = oneDimensionalPosition - (vertical * 3);
            return new Position(horizontal, vertical);
        }

        public void ShowGameResult(GameBoard board, Player player, GameStatus gameStauts)
        {
            if (gameStauts == GameStatus.PlayerWon)
            {
                System.Windows.MessageBox.Show("Game over! " + player.name + " won!");
            }
            if (gameStauts == GameStatus.Tie)
            {
                System.Windows.MessageBox.Show("Tie!");
            }
        }
    }
}
