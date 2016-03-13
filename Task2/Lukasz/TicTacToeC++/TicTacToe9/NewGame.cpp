#include "stdafx.h"
#include "NewGame.h"
#include <iostream>
using namespace std;

NewGame::NewGame()
{
	Board board;
	for (int moveNum = 0; moveNum < 9; moveNum++)
	{
		board.DisplayBoard();
		Game game;
		game.nextMove(moveNum);
		int fieldNum;
		cin >> fieldNum;
		if (cin.fail() || fieldNum < 1 || fieldNum>9)
		{
			moveNum--;
			cout << "\n\tInvalid move! Pick number from 1 - 9" << endl;
			cin.clear();
			cin.ignore(numeric_limits<streamsize>::max(), '\n');
			system("pause");
		}
		else
			game.markPlayer(board, fieldNum, moveNum);
		system("cls");

		if (game.checkWin(board) == true)
		{
			board.DisplayBoard();
			cout << "\n\n\tPlayer " << board.getField(fieldNum) << " wins!\n" << endl;
			break;
		}
	}
	if (game.checkWin(board) != true)
		cout << "\n\n\tIt is a draw!\n" << endl;
	system("pause");
}
