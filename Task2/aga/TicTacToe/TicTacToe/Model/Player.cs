using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class Player
    {
        public Player(string symbol)
        {
            Symbol = symbol;
        }

        public string Symbol { get; set; }

    }
}
