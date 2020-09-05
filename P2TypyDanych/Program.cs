using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2TypyDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            // typy liczbowe calkowite - int
            int liczba = 5 ; // 5 - literal int
            Console.WriteLine(liczba);
            liczba = 10 ;
            Console.WriteLine(liczba);

            Console.WriteLine( 5.GetType() );

            // typy zmiennoprzecinkowe
            double liczba2 = 3.14; // 3.14 - literał double
            Console.WriteLine(liczba2);
            Console.WriteLine(3.14.GetType());
            Console.WriteLine(liczba2.GetType());

            float liczba3 = 2.5f; // 2.5f - literał float
            Console.WriteLine(liczba3);
            Console.WriteLine(2.5.GetType());
            Console.WriteLine(2.5f.GetType());

            //suffiksy do literałow

            Console.WriteLine(5.GetType()); //System.Int32
            Console.WriteLine(5L.GetType()); //System.Int64
            Console.WriteLine(5U.GetType()); //System.UInt32
            Console.WriteLine(5UL.GetType()); // System.UInt64

            Console.WriteLine(5.0.GetType()); // System.Double
            Console.WriteLine(5.0F.GetType()); // System.Single , float
            Console.WriteLine(5.0D.GetType()); // System.Double
            Console.WriteLine(5.0M.GetType()); // System.Decimal


            // typ boolean

            bool zmiennaBoolean = true;
            zmiennaBoolean = false;
            Console.WriteLine(zmiennaBoolean);

            // ciągi znaków, napisy, string

            string imie = "Piotr"; // "Piotr" literał typu string
            Console.WriteLine(imie);

            Console.WriteLine("Adam Mickiewicz napisał książke \"Pan Tadeusz\".");
            Console.WriteLine("Adam Mickiewicz napisał książke 'Pan Tadeusz'.");
            Console.WriteLine("Ala ma kota " + "a kot ma kompilator");
            Console.WriteLine("Ala ma kota \na kot ma kompilator");

            // char - pojedynczy znak

            char litera = 'A'; // tutaj mamy pojedynczy  cudzyslow
            Console.WriteLine(litera);

            string lokalizacja = "c:\\katalog";
            Console.WriteLine(lokalizacja);

            string lokalizacja2 = @"C:\katalog"; // @ - verbatim operator
            Console.WriteLine(lokalizacja2);

            // przy użuciu operatora @ jak chcemy mieć " w napisie to zapisujemy go jako ""
            string tytul = @"Adam Mickiewicz napisał kśiazke ""Pan Tadeusz."".";
            Console.WriteLine(tytul);

            // konkatenacja - laczenie kilku stringów
            string polaczonyNapis = "Ala " + "ma " + "kota";
            Console.WriteLine(polaczonyNapis);

            imie = "Radek";
            string nazwisko = "Punda";

            string przywitanie = " Cześć " + imie + " " + nazwisko + "!";
            Console.WriteLine(przywitanie);

            // string interpolation
            string przywitanie2 = $"Cześc {imie} {nazwisko}!";
            Console.WriteLine(przywitanie2);

            // dostep do pszczegolnych znaków w napisie
            string literki = "abcdefgh";
            //                01234567
            Console.WriteLine(literki[2]); // c

            string zmiennaNapisowa = null; // wartość mówiąca że nic nie ma 
            Console.WriteLine(zmiennaNapisowa);

            string zmiennaNapisowa2 = "";
            Console.WriteLine(zmiennaNapisowa2);

            // operatory arytmetyczne 
            Console.WriteLine(10 + 3);
            Console.WriteLine(10 - 3);
            Console.WriteLine(10 * 3);
            Console.WriteLine(10.0 / 3.0);
            Console.WriteLine(10 % 2);

            // operatory porówniania - zwracają wartość bool 
            Console.WriteLine(1 == 1); // true
            Console.WriteLine(1 != 1); // false
            Console.WriteLine(1 > 2); // false
            Console.WriteLine(1 < 2); // true
            Console.WriteLine(1 <= 2); // true
            Console.WriteLine(1 >= 2); // true
            Console.WriteLine( (1+2) == (5-2)); // true

            Console.WriteLine("ala" == "ala"); // tak nie zaleca sie porownywac napisow 
            Console.WriteLine("ala".Equals("ala")); // to jest prawidlowo

            // operatory przypisania

            int wartosc = 1; // = -> przypisania
            wartosc += 10; // wartosc = wartosc + 10
            wartosc -= 10;
            wartosc *= 5;
            wartosc /= 5;


            wartosc = 10;
            wartosc++; // zwiekszenie wartosc zmiennej o 1, operator postinkrementacji
            wartosc--; // zmniejszenie wartosci o 1, oeprator postdecrementacji

            // Mamy operator PREinkrementacji i POSTinkrementacji

            wartosc = 100;
            Console.WriteLine(wartosc++);
            Console.WriteLine(wartosc);

            wartosc = 100;
            Console.WriteLine(++wartosc);
            Console.WriteLine(wartosc);

            // operaotry logiczne

            bool a = true;
            bool b = false;
            Console.WriteLine(a && b); // logiczne i
            Console.WriteLine(a || b); // logiczne lub , alternatywa
            Console.WriteLine(!a); // negacja, zaprzeczenie
            Console.WriteLine(!b); // negacja, zaprzeczenie

            // instrukcje sterujace
            Console.WriteLine("Podaj liczbe: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            
            if (liczba > 0) // kod wykona sie jesli jest prawdziwy
            {
                Console.WriteLine("Liczba, którą podałes jest wieksza od 0");

            }
            else if (liczba == 0) // kod wykona sie jesli pierwszy warunek bedzie falszywy a warunek2 bedzie prawidlowy
            {
                Console.WriteLine("Liczba, ktora podałes jest rowna 0");
            }
            else // kod ktory sie wykona jesli poprzednie warunki beda nie prawdziwe
            {
                Console.WriteLine("Liczba którą podałes jest mniejsza od 0");
            }
            Console.WriteLine("Dziękujemy za skorzystanie z naszeg programu");



            Console.ReadKey();
        }
    }
}
