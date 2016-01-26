using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int poczatek = 2;
            Console.WriteLine("Podaj koniec przedzialu, aby wyswietlic zawarte w nim liczby pierwsze ");
            int koniec = int.Parse(Console.ReadLine());

            for (poczatek=2; poczatek <= koniec; poczatek++)
            {
                for (int dzielnik = 2; dzielnik <= poczatek; dzielnik++)
                {
                    if (poczatek % dzielnik == 0)
                    {
                        if (poczatek == dzielnik)
                        Console.Write(poczatek + ", ");
                        else break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
