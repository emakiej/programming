#pragma once
#include <string>
#include <vector>
#include "Board.h"

class Game
{
private:
	Board board;
public:
	Game();
	void nextMove(int moveNum);
	void markPlayer(Board &board, int fieldNum, int &moveNumber);
	bool isEmptyField(Board board, int fieldNum);
	bool checkWin(Board board);
};