// isPrime.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	cout << "Podaj koniec przedzialu, aby wyswietlic zawarte w nim liczby pierwsze ";
	int koniec;
	cin >> koniec;

	for (int liczba = 2; liczba <= koniec; liczba++)
	{
		for (int dzielnik = 2; dzielnik <= liczba; dzielnik++)
		{			
			if (liczba % dzielnik == 0)
			{
				if (liczba == dzielnik)
					cout << liczba << ", ";
				else break;
			}	
		}
	}

	system("pause");
	return 0;
}

