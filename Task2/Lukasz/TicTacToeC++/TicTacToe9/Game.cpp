#include "stdafx.h"
#include <iostream>
#include "Game.h"
using namespace std;

Game::Game() {}

void Game::nextMove(int moveNum)
{
	if (moveNum % 2 == 0)
		cout << "\n\tPick from 1-9" << "\n\tPlayer ""X"" move: ";
	else
		cout << "\n\tPick from 1-9" << "\n\tPlayer ""O"" move: ";
}

void Game::markPlayer(Board &board, int fieldNum, int &moveNum)
{
	if (isEmptyField(board, fieldNum) == false)
	{
		moveNum--;
		cout << "\n\tInvalid move! Field is NOT empty ";
		system("pause");
	}
	else
	{
		if (moveNum % 2 == 0)
			board.setField(fieldNum, 'X');
		else
			board.setField(fieldNum, 'O');
	}
}

bool Game::isEmptyField(Board board, int fieldNum)
{
	if (board.getField(fieldNum) == 'X' || board.getField(fieldNum) == 'O')
		return false;
}

bool Game::checkWin(Board board)
{
	if (board.getField(1) == board.getField(2) && board.getField(2) == board.getField(3))
		return true;
	else if (board.getField(4) == board.getField(5) && board.getField(5) == board.getField(6))
		return true;
	else if (board.getField(7) == board.getField(8) && board.getField(8) == board.getField(9))
		return true;
	else if (board.getField(1) == board.getField(4) && board.getField(4) == board.getField(7))
		return true;
	else if (board.getField(2) == board.getField(5) && board.getField(5) == board.getField(8))
		return true;
	else if (board.getField(3) == board.getField(6) && board.getField(6) == board.getField(9))
		return true;
	else if (board.getField(1) == board.getField(5) && board.getField(5) == board.getField(9))
		return true;
	else if (board.getField(3) == board.getField(5) && board.getField(5) == board.getField(7))
		return true;
}
