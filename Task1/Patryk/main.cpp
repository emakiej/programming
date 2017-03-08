#include <iostream>
#include <cstdio>

using namespace std;

bool isPrime(int value)
{
    bool isPrimeInd = true;
    int i = 2;
    do
    {
        if ((value % i == 0 || value < 2) && value!=2)
        {
            isPrimeInd = false;
            break;
		}
        i++;
    }while (i<value);
	return isPrimeInd;
}

void primeChecker(int value)
{
    if(isPrime(value))
    {
        cout << value << " is prime!" << endl;
    }
    else
        cout << value << " is not prime!" << endl;
}

void listOfPrimes(int value)
{
    cout << "All primes that are less than " << value <<endl;
    for(int i=1; i<value; i++)
    {
        if(isPrime(i))
        {
                cout << i << "  ";
        }
    }
}

int main()
{
    int number;
    cout << "isPrime checker" << endl << "Please provide a number to check:" << endl;
    cin>>number;

    primeChecker(number);
    listOfPrimes(number);

    getchar(); getchar();
    return 0;
}
