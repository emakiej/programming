#pragma once
#include <vector>
class Board
{
private:
	std::vector <char> board;
public:
	Board();
	void setField(int fieldNum, char entry);
	char getField(int fieldNum);
	void DisplayBoard();
};
