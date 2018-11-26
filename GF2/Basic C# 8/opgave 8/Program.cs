using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace opgave_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //String svar; (Variable bruges til linje 52)
            string svar;

            //do while løkke bliver ved med at køre så længe svaret bliver ved med at være " j eller J " 
            do
            {
                //Console.WriteLine(Skriver Tekst til Bruger);
                Console.WriteLine("Hej Her kan du vælge tabel mellem 1 - 10 du vil have vist");
                Console.WriteLine("Dette kan gøres ved at skrive et tal mellem 1 og 10");

                //Console.Readline( Læser Bruger indput)
                String str = Console.ReadLine();
                // int tabel = Int32.Parse(str) (laver Bruger indput til en Variable.)
                int tabel = Int32.Parse(str);

                //Forløkke
                for (int i = 1; i <= 10; i++)
                {
                    int resultat = tabel * i;
                    Console.Write(resultat.ToString().PadLeft(4));
                }

                Console.WriteLine();
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

                //Console.WriteLine(Stille spørgsmål til bruger)
                Console.WriteLine("Ønser du at prøve igen? j/n");
                //Modtager svar fra bruger og overføger til String svar på linje 17
                svar = Console.ReadLine();


            } while (svar == "J" || svar == "j");
            
        }

    }

}


