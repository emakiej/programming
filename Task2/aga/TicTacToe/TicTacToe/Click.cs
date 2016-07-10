using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Click
    {
        private int turn = 1;
        public Click()
            { }

        public void TurnCounter()
            {
                turn++;
            }
        public int GetTurn()
        {
            return turn;
        }
    }
}
