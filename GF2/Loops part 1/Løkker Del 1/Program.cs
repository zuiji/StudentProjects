﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Løkker_Del_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            //skriver på kosol:
            //  0,1,2,3,4

            for (double i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
            // Skriver på konsol:
            //  0, 2, 4, 6, 8

            for (int x = 5; x > 0; x--)
            {
                Console.WriteLine(x);
            }
            //skriver på konsol:
            //  5, 4, 3, 2, 1

            Console.WriteLine();
            for (double y = 0; y < 1; y += 0.25)
            {
                Console.WriteLine(y.ToString("n2"));
                
            }
            //skriver op konsol:
            //  0.00, 0.25, 0.50, 0.75


            Console.WriteLine();
            for (int i = 1; i < 11; i++)
            {
                for (int x = 1; x < 11; x++)
                {
                    int resultat = i * x;
                    Console.Write(resultat.ToString().PadLeft(4));
                }
                Console.WriteLine();
                Console.ReadKey();

                //skriver på konsol:
                //  1  2  3  4  5  6  7  8  9 10
                //  2  4  6  8 10 12 14 16 18 20
                //  3  6  9 12 15 18 21 24 27 30
                //  4  8 12 16 20 24 28 32 36 40
                //  5 10 15 20 25 30 35 40 45 50 
                //  6 12 18 24 30 36 42 48 54 60
                //  7 14 21 28 35 42 49 56 63 70
                //  8 16 24 32 40 48 56 64 72 80
                //  9 18 27 36 45 54 63 72 81 90
                // 10 20 30 40 50 60 70 80 90 100
            }
                // i og resultat kan ikke bruges her. 
               for (int i = 0; i < 10; i++)
               {
                  int resultat;
                // her kan i og resultat bruges
               }
            // i og resultat kan ikke bruges her.
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
