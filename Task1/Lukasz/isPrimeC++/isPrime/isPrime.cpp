// isPrime.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int poczatek = 2;
	cout << "Podaj koniec przedzialu, aby wyswietlic zawarte w nim liczby pierwsze ";
	int koniec;
	cin >> koniec;

	for (poczatek; poczatek <= koniec; poczatek++)
	{
		for (int dzielnik = 2; dzielnik <= poczatek; dzielnik++)
		{			
			if (poczatek % dzielnik == 0)
			{
				if (poczatek == dzielnik)
				cout << poczatek << ", ";
				else break;
			}	
		}
	}

	system("pause");
    return 0;
}

