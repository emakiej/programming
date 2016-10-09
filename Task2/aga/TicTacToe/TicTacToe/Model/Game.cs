using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.ViewModel;

namespace TicTacToe.Model
{
    class Game
    {
        private readonly List<Player> _players;
        private int turn = 1;
        private string winner;
        private string param;

        public Game(IEnumerable<Player> players)
        {
            _players = new List<Player>(players);
        }

        public int GetTurn()
        {
            return turn;
        }

        public void MakeMove(ButtonViewModel[][] buttonsViewModel, int buttonX, int buttonY)
        {
            var button = buttonsViewModel[buttonX][buttonY];
            if (winner != null)
            { param = "tryAgain"; }
            else if (string.IsNullOrEmpty(button.Value))
            {
                button.MarkForPlayer(GetCurrentPlayer());
                if (WasWon(buttonsViewModel, buttonX, buttonY))
                {
                    winner = GetCurrentPlayer().Symbol;
                    param = "winner";
                }
                else if (CheckIfDraw(buttonsViewModel))
                { param = "draw"; }
                else
                { turn++; }
            }            
        }

        public Player GetCurrentPlayer()
        {
            var currentPlayerNo = (GetTurn() - 1) % _players.Count;
            return _players[currentPlayerNo];
        }

        public bool WasWon(ButtonViewModel[][] buttonsViewModel, int buttonX, int buttonY)
        {
            var button = buttonsViewModel[buttonX][buttonY];
            if (button.Value == buttonsViewModel[0][buttonY].Value && button.Value == buttonsViewModel[1][buttonY].Value && button.Value == buttonsViewModel[2][buttonY].Value)
            { return true; }
            else if (button.Value == buttonsViewModel[buttonX][0].Value && button.Value == buttonsViewModel[buttonX][1].Value && button.Value == buttonsViewModel[buttonX][2].Value)
            { return true; }
            else if ((Math.Abs(buttonX-buttonY)==2 || buttonY==buttonX) && (buttonsViewModel[0][0].Value == buttonsViewModel[1][1].Value && buttonsViewModel[0][0].Value == buttonsViewModel[2][2].Value || buttonsViewModel[2][0].Value == buttonsViewModel[1][1].Value && buttonsViewModel[2][0].Value == buttonsViewModel[0][2].Value) && !string.IsNullOrEmpty(buttonsViewModel[1][1].Value))
            { return true; }
            else { return false; }
        }

        public string GetCurrentParam()
        { return param; }

        public string GetWinner()
        { return winner; }

        public bool CheckIfDraw(ButtonViewModel[][] buttonsViewModel)
        {
            int emptyField = 0;
            for (int i = 0;  i < 3;  i++)
            {
                var buttonX = i;
                for (int j = 0; j < 3; j++)
                {
                    var buttonY = j;
                    if (string.IsNullOrEmpty(buttonsViewModel[buttonX][buttonY].Value))
                    {
                        emptyField++;
                    }
                }

            }
            if (emptyField == 0)
            { return true; }
            else
            { return false; }
        }
        
    }

    enum GameState
    {
        GameWon,
        GameDraw
    }
}
