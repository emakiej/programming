using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace NoughtsAndCrossesWPF
{
    public class ViewModel
    {
        
        private string[] translatedOneDimensionalBoard = new string[GameBoard.boardSize * GameBoard.boardSize];
        private ObservableCollection<string> _ObservableBoard;
        static WPFBoardCommunication communicator = new WPFBoardCommunication();
        Game game = new Game(communicator);
        public ObservableCollection<string> ObservableBoard { get { return _ObservableBoard; } }

        public ViewModel()
        {
            _ObservableBoard = new ObservableCollection<string>(translatedOneDimensionalBoard);
        }

        private void ShowBoard()
        {
            for (int i = 0; i < translatedOneDimensionalBoard.Length; i++)
            {
                Position coordinates = communicator.TranslateOneDimensionalPosition(i);
                ObservableBoard[i] = TranslateBoardSymbol(game.board.fields[coordinates.Vertical, coordinates.Horizontal]);
            }
        }

        private string TranslateBoardSymbol(GameBoardStatus symbol)
        {
            if (symbol == GameBoardStatus.empty) return "";
            if (symbol == GameBoardStatus.cross) return "X";
            return "O";
        }

        private ICommand _markFieldCommand;
        private bool _canExecute = true;

        public ICommand MarkFieldCommand
        {
            get
            {
                return _markFieldCommand ?? (_markFieldCommand = new CommandHandler(param => MarkFieldActions(param),_canExecute));
            }
        }
        
        private void MarkFieldActions(object field)
        {
            game.MakeTurn(field);
            ShowBoard();
        }

        private ICommand _resetGame;

        public ICommand ResetGame
        {
            get
            {
                return _resetGame ?? (_resetGame = new CommandHandler(param => Reset(), _canExecute));
            }
        }

        private void Reset()
        {
            game.board.EmptyTheBoard();
            ShowBoard();
        }
    }
}