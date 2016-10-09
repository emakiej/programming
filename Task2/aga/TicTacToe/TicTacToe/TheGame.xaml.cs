using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for TheGame.xaml
    /// </summary>
    public partial class TheGame : Window
    {
        public TheGame()
        {
            InitializeComponent();

        }
        Click click = new Click();
        private bool[] clickedButtons = new bool[9];
        private object winner = "";

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;            
            int turn = click.GetTurn();
            int param = 0;

            displayButton(turn, b, param);

        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int turn = click.GetTurn();
            int param = 1;

            displayButton(turn, b, param);
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int turn = click.GetTurn();
            int param = 2;

            displayButton(turn, b, param);
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int turn = click.GetTurn();
            int param = 3;

            displayButton(turn, b, param);
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int turn = click.GetTurn();
            int param = 4;

            displayButton(turn, b, param);
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int turn = click.GetTurn();
            int param = 5;

            displayButton(turn, b, param);
        }

        private void C1_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int turn = click.GetTurn();
            int param = 6;

            displayButton(turn, b, param);
        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int turn = click.GetTurn();
            int param = 7;

            displayButton(turn, b, param);
        }
        private void C3_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int turn = click.GetTurn();
            int param = 8;

            displayButton(turn, b, param);
        }

        private void displayTurn(int t)
        {
            Label l = diplayTurn;
            l.Content = t;
        }

        private void displayMessageBox(int param, int turn)
        {
            Label l = messageBox;
            
            if (wasWinned())
                { l.Content = "The winner is "+ winner; }
            else if (turn == 9)
                {
                    l.Content = "It's a draw!";
                    tryAgain.Visibility = Visibility.Visible;
                }
            else if (wasClicked(param))
            { l.Content = "Choose different field"; }
            else
                {
                    if (turn % 2 != 0)
                    {
                        l.Content = "Player O turn";
                    }
                    else
                    {
                        l.Content = "Player X turn";
                    }
                }
        }

        private void displayButton(int turn, Button b, int param)
        {
            
            if (!wasClicked(param) && !wasWinned())

            {   
                if (turn % 2 != 0)
                {
                    b.Content = "X";
                }
                else
                {
                    b.Content = "O";
                }
                displayMessageBox(param, turn);
                clickedButtons[param] = true;
                click.TurnCounter();
                displayTurn(turn);
            }
            else
                { displayMessageBox(param, turn); }
            
        }

        private bool wasClicked(int param)
        {
            return clickedButtons[param];           
        }

        private bool wasWinned()
        {
            if (A1.Content == A2.Content && A1.Content == A3.Content && A1.Content!=null)
                {
                    winner = A1.Content;
                    tryAgain.Visibility = Visibility.Visible;
                    return true;
                }
            else if (B1.Content == B2.Content && B1.Content == B3.Content && B1.Content != null)
                {
                    winner = B1.Content;
                    tryAgain.Visibility = Visibility.Visible;
                    return true;
                }
            else if (C1.Content == C2.Content && C1.Content == C3.Content && C1.Content != null)
                {
                    winner = C1.Content;
                    tryAgain.Visibility = Visibility.Visible;
                    return true;
                }
            else if (A1.Content == B1.Content && A1.Content == C1.Content && A1.Content != null)
                {
                    winner = A1.Content;
                    tryAgain.Visibility = Visibility.Visible;
                    return true;
                }
            else if (A2.Content == B2.Content && A2.Content == C2.Content && A2.Content != null)
                {
                    winner = A2.Content;
                    tryAgain.Visibility = Visibility.Visible;
                    return true;
                }
            else if (A3.Content == B3.Content && A3.Content == C3.Content && A3.Content != null)
                {
                    winner = A3.Content;
                    tryAgain.Visibility = Visibility.Visible;
                    return true;
                }
            else if (A1.Content == B2.Content && A1.Content == C3.Content && A1.Content != null)
                {
                    winner = A1.Content;
                    tryAgain.Visibility = Visibility.Visible;
                    return true;
                }
            else if (A3.Content == B2.Content && A3.Content == C1.Content && A3.Content != null)
                {
                    winner = A3.Content;
                    tryAgain.Visibility = Visibility.Visible;
                    return true;
                }
            else
                { return false; }
        }

        private void tryAgain_Click(object sender, RoutedEventArgs e)
        {
            click = new Click();
            messageBox.Content = "Player X turn";
            diplayTurn.Content = "";
            A1.Content = B1.Content = C1.Content = A2.Content = B2.Content = C2.Content = A3.Content = B3.Content = C3.Content = null;
            for (int i = 0; i<9;i++)
                {
                clickedButtons[i] = false;
                }
            winner = "";
            tryAgain.Visibility = Visibility.Hidden;
        }
    }
}
