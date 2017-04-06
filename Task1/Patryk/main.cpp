#include <iostream>
#include <cstdio>

using namespace std;

bool checkIfPrime(int value)
{
    if (value < 2)
    {
        return false;
    }

    for(int i=2; i<value; i++)
    {
        if(value % i == 0)
        {
            return false;
        }
    }
}

void printListOfSmallerPrimes(int value)
{
        cout << "All primes that are less than " << value <<endl;
        for(int i=1; i<value; i++)
        {
            if(checkIfPrime(i))
            {
                cout << i << "  ";
            }
        }
}

void printPrimeCheckResult(int value)
{
    if(checkIfPrime(value))
    {
        cout << value << " is prime!" << endl;
        printListOfSmallerPrimes(value);
    }
    else
        cout << value << " is not prime!" << endl;
}



int main()
{
    int number;
    cout << "isPrime checker" << endl << "Please provide a number to check:" << endl;
    cin>>number;

    printPrimeCheckResult(number);

    getchar();

    return 0;
}
