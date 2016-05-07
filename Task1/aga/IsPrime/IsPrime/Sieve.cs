using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    internal class Sieve
    {
        private int _max;

        public Sieve(int val)
        {
           _max=val;
        }
        
        private bool[] MakeSieve()
        {
            bool[] isPrime = new bool[_max + 1];
            for (int i = 2; i<=_max; i++) { isPrime[i] = true; }
            for (int i = 2; i<=_max;i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * 2; j<=_max; j+=i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            return isPrime;
        }

        public List<int> GetPrimes()
        {
            bool[] primes = MakeSieve();
            List<int> primeList = new List<int>();
            for (int i = 2; i<=_max;i++)
            {
                if (primes[i])
                {
                    primeList.Add(i);
                }
            }
            return primeList;
        }


    }
}
