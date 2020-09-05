using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace P4Wypisywanie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisz program wypisujący na konsolę Twoje imię i wiek. Do przechowywania informacji o Twoim imieniu i wzroście użyj zmiennych.
            */

            Console.WriteLine("Podaj swoje imie: ");
            string imie = Console.ReadLine();

            Console.WriteLine("Podaj swoj wiek: ");
            int wiek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Masz na imie {imie} i masz {wiek} lat");

            // Kilka przydatnych metod na stringach

            Console.WriteLine("Imie: " + imie.ToUpper());
            Console.WriteLine("Imie: " + imie.ToLower());
            Console.WriteLine("Imie: " + imie.Replace("a", "*")); // prosty mechanizm znajdz i zamien
            Console.WriteLine("Długośc imienia: " + imie.Length);
            Console.WriteLine("Czy imie jest puste? " + String.IsNullOrEmpty(imie));
            Console.WriteLine("Czy imie jest puste? " + String.IsNullOrWhiteSpace(imie));

            // jak jest pelnoletni: Jestes pelnoletni i mozesz kupic piwo.
            if (wiek > 0 && wiek < 120)
            {
                if (wiek >= 18)
                {
                    Console.WriteLine("Jesteś pełnoletni, mozesz kupic piwo");
                }
                else
                {
                    Console.WriteLine("Nie jesteś pelnoletni,mozesz kupic cukierki");
                }
            }
            else
            {
                Console.WriteLine("Podałes nie prawidlowy wiek");
            }
            

            // jak nie jestes pelnoeltni: Jest nie pelnoletni i mozesz kupic cukierki

            Console.ReadLine();

        }
    }
}
