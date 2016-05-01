using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class IsPrime
    {
        private static int max;

        public IsPrime(int val)
        {
           SetMax(val);
        }
        
        public void SetMax(int val)
        {
            max = val;
        }

        private bool[] MakeSieve()
        {
            bool[] isPrime = new bool[max + 1];
            for (int i = 2; i<=max; i++) { isPrime[i] = true; }
            for (int i = 2; i<=max;i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * 2; j<=max; j+=i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            return isPrime;
        }

        public void GetPrimes()
        {
            bool[] primes = MakeSieve();
            for (int i = 2; i<=max;i++)
            {
                if (primes[i])
                {
                    Console.Write("{0} ", i);
                }
            }
        }


    }
}
