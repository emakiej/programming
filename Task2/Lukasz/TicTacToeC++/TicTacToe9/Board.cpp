#include "stdafx.h"
#include <iostream>
#include <string>
#include "Board.h"
using namespace std;
Board::Board()
{
	for (int i = 0; i < 9; i++)
	{
		string s = to_string(i + 1);
		char const *pchar = s.c_str();
		board.push_back(*pchar);
	}
}

void Board::setField(int fieldNum, char entry)
{
	board[fieldNum - 1] = entry;
}

char Board::getField(int fieldNum)
{
	return board[fieldNum - 1];
}

void Board::DisplayBoard()
{
	cout << "\n\tTic Tac Toe";
	cout << "\n\n\t[" << board[0] << "] [" << board[1] << "] [" << board[2] << "]" << endl;
	cout << "\t[" << board[3] << "] [" << board[4] << "] [" << board[5] << "]" << endl;
	cout << "\t[" << board[6] << "] [" << board[7] << "] [" << board[8] << "]" << endl;
}
