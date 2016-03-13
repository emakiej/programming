#include "stdafx.h"
#include "UserInterface.h"
#include "NewGame.h"
#include "StartPanel.h"
#include <iostream>
using namespace std;

UserInterface::UserInterface()
{
	StartPanel panel;
	int choice;
	do
	{
		cout << "\n\tTic Tac Toe" << endl;
		cout << "\n\t[1] Start New Game";
		cout << "\n\t[2] Exit" << endl;
		cin >> choice;
		system("cls");
		if (choice == StartNewGame)
			NewGame start;
		else if (choice == Exit)
			choice = Exit;
		else
		{
			cout << "\t\nChoose 1 or 2\n\n";
			system("pause");
			system("cls");
			cin.clear();
			cin.ignore(numeric_limits<streamsize>::max(), '\n');
		}
	} while (choice != Exit);
	cout << "\n\tGoog bye!\n\n";
}

