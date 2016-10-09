using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Model;
using GalaSoft.MvvmLight;

namespace TicTacToe.ViewModel
{
    public class ButtonViewModel : ViewModelBase
    {
        private Button _button;
        private string _value;

        public ButtonViewModel()
        {
            _button = new Button();
        }

        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                RaisePropertyChanged("Value");
                _button.Value = value;
            }
        }

        public void MarkForPlayer(Player player)
        {
           Value = player.Symbol;

        }

        public void Reset()
        {
            Value = "";
        }



       
    }
}
