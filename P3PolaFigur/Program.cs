using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PolaFigur
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Oblicz następujące wartości:
            -pole trójkąta o podstawie 10 i wysokości 5
           - pole koła o promieniu 7
           - pole trapezu o długości podstaw 3 i 9 oraz wysokości 6.5
           - objętość kuli o promieniu 7 / 8 
            */

            //int a = 7 2;
            int b = (7 / 8) * 3;
            Console.WriteLine(10*5/2);
            Console.WriteLine(Math.PI * Math.Pow(7, 2));
            Console.WriteLine((3.0 + 9.0) * 6.5 / 2.0);
            Console.WriteLine(4/3*3.14*b);
            Console.WriteLine(4.0/3.0 * Math.PI * Math.Pow(7.0/8.0, 3));
            Console.ReadKey();
        }
    }
}
