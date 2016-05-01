using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPrime isPrime = new IsPrime(Convert.ToInt32(Console.ReadLine()));

            isPrime.GetPrimes();
            Console.ReadKey();
        }
    }
}
