using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Model;
using TicTacToe.ViewModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;


namespace TicTacToe.ViewModel
{
    public class BoardViewModel : ViewModelBase
    {
        private const int BoardDimension = 3;
        private Game _game;
        ButtonViewModel[][] _buttons;
        public ButtonViewModel[][] Buttons {
            get { return _buttons; }
            set {
                Set(() => Buttons, ref _buttons, value);
            }
        }
        public RelayCommand<string> ButtonClickCommand { get; }
        public RelayCommand ButtonResetGame { get; }
        

        public BoardViewModel()
        {
            ButtonClickCommand = new RelayCommand<string>(ButtonClickAction);
            ButtonResetGame = new RelayCommand(ResetGame);
            InitializeButtons();
            _game = new Game(new[] { new Player("X"), new Player("O") });
        }
        
        private void ButtonClickAction(string buttonNumber)
        {
            var buttonX = Convert.ToInt32(buttonNumber) / BoardDimension;
            var buttonY = Convert.ToInt32(buttonNumber) % BoardDimension;
            _game.MakeMove(Buttons, buttonX, buttonY);
            
            RaisePropertyChanged(() => InfoText);
            RaisePropertyChanged(() => CurrentTurn);
            RaisePropertyChanged(() => TryAgainVisibility);
        }

        private void InitializeButtons()
        {
            Buttons = new ButtonViewModel[BoardDimension][];
            for (int i = 0; i < BoardDimension; i++)
            {
                Buttons[i] = new ButtonViewModel[3];
                for (int j = 0; j < BoardDimension; j++)
                    Buttons[i][j] = new ButtonViewModel();
            }
        }

        private Player CurrentPlayer => _game.GetCurrentPlayer();

        public string InfoText => ChangeInfoText(_game.GetCurrentParam(), _game.GetWinner());

        public string CurrentTurn => _game.GetTurn().ToString();

        public bool TryAgainVisibility => ChangeTryAgainVisibility(_game.GetCurrentParam());

        public string ChangeInfoText(string param, string winner)
        {
            string _text;
            if (param == "winner")
            { _text = $"The winner is { CurrentPlayer.Symbol}"; }
            else if (param == "tryAgain")
            { _text = "The game has ended. Try again"; }
            else if (param == "draw")
            { _text = "It's a draw. Try again"; }
            else
            { _text = $"Player {CurrentPlayer.Symbol} turn"; }
            return _text;
        }

        public bool ChangeTryAgainVisibility(string param)
        {
            bool _visibility = false;
            if (param == "draw" || param == "winner" || param == "tryAgain")
            { _visibility = true; }
            return _visibility;
        }

        public void ResetGame()
        {
            foreach (var buttonRow in Buttons)
                foreach (var button in buttonRow)
                    button.Reset();
            _game = new Game(new[] { new Player("X"), new Player("O") });

            RaisePropertyChanged(() => InfoText);
            RaisePropertyChanged(() => CurrentTurn);
            RaisePropertyChanged(() => TryAgainVisibility);
        }

    }
}
