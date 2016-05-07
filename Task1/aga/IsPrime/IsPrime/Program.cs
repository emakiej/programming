using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input an integer:");
            string userValue = Console.ReadLine();

            try
            {
                int intValue = int.Parse(userValue);
                Sieve sieve = new Sieve(intValue);
                Console.Write("Your primes are: ");
                sieve.GetPrimes().ForEach(i => Console.Write("{0}\t", i));
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Main();
            }
            
        }

        
    }
}
