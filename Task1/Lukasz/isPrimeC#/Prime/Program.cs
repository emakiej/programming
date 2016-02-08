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
            Console.WriteLine("Podaj koniec przedzialu, aby wyswietlic zawarte w nim liczby pierwsze ");
            int koniec = int.Parse(Console.ReadLine());

            for (int liczba=2; liczba <= koniec; liczba++)
            {
                for (int dzielnik = 2; dzielnik <= liczba; dzielnik++)
                {
                    if (liczba % dzielnik == 0)
                    {
                        if (liczba == dzielnik)
                        Console.Write(liczba + ", ");
                        else break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
