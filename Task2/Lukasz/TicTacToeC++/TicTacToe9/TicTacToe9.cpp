// TicTacToe9.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;
bool checkWin(char board[])
{
	if (board[0] == board[1] && board[1] == board[2])
		return true;
	else if (board[3] == board[4] && board[4] == board[5])
		return true;
	else if (board[6] == board[7] && board[7] == board[8])
		return true;
	else if (board[0] == board[3] && board[3] == board[6])
		return true;
	else if (board[1] == board[4] && board[4] == board[7])
		return true;
	else if (board[2] == board[5] && board[5] == board[8])
		return true;
	else if (board[0] == board[4] && board[4] == board[8])
		return true;
	else if (board[2] == board[4] && board[4] == board[6])
		return true;
}

bool isEmpty(char board[], int field_num)
{
	if (board[field_num - 1] == 'X' || board[field_num - 1] == 'O')
		return false;
}

void markPlayer(char board[], int move_num, int field_num)
{
	if (move_num % 2 == 0)
		board[field_num - 1] = 'X';
	else
		board[field_num - 1] = 'O';
}

void theBoard(char board[], int move_num)
{
	system("cls");
	cout << "\n\tTic Tac Toe";
	cout << "\n\n\t[" << board[0] << "] [" << board[1] << "] [" << board[2] << "]" << endl;
	cout << "\t[" << board[3] << "] [" << board[4] << "] [" << board[5] << "]" << endl;
	cout << "\t[" << board[6] << "] [" << board[7] << "] [" << board[8] << "]" << endl;
	if (move_num % 2 == 0)
		cout << "\n\tPlayer ""X"" move: ";
	else
		cout << "\n\tPlayer ""O"" move: ";
}

void markField(char board[], int field_num, int &move_num)
{
	if (isEmpty(board, field_num) == false)
	{
		move_num--;
		cout << "\n\tInvalid move! ";
		system("pause");
	}
	else
		markPlayer(board, move_num, field_num);
}

void newGame()
{
	char board[9] = { '1','2','3','4','5','6','7','8','9' };
	for (int move_num = 0; move_num < 9; move_num++)
	{
		theBoard(board, move_num);
		int field_num;
		cin >> field_num;
		switch (field_num)
		{
		case 1:
			markField(board, field_num, move_num);
			break;
		case 2:
			markField(board, field_num, move_num);
			break;
		case 3:
			markField(board, field_num, move_num);
			break;
		case 4:
			markField(board, field_num, move_num);
			break;
		case 5:
			markField(board, field_num, move_num);
			break;
		case 6:
			markField(board, field_num, move_num);
			break;
		case 7:
			markField(board, field_num, move_num);
			break;
		case 8:
			markField(board, field_num, move_num);
			break;
		case 9:
			markField(board, field_num, move_num);
			break;
		default:
			move_num--;
			break;
		}
		if (checkWin(board) == true)
		{
			theBoard(board, move_num);
			cout << "\n\n\tPlayer " << board[field_num - 1] << " wins!\n" << endl;
			break;
		}
		else
			theBoard(board, move_num);
	}
	if (checkWin(board) != true)
		cout << "\n\n\tIt is a draw!\n" << endl;
	system("pause");
	system("cls");
}

int main()
{
	int choice;
	do
	{
		cout << "\n\tTic Tac Toe" << endl;
		cout << "\n\t[1] New Game";
		cout << "\n\t[2] Exit" << endl;
		cin >> choice;
		if (choice == 1)
			newGame();
		else
			cout << "Choose 1 or 2";
	} while (choice != 2);
}

