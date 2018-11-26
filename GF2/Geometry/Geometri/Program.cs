using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    { 

        /* Denne opgave er lavet i samarbejde med Benjamin og adam
        */
        //Indput fra Bruger til alle 3 opgaver.
        static double getintfromuser(string spørgsmål1)
        {
            Console.WriteLine(spørgsmål1);
            string input;
            //resultat
            double resultat;
            input = Console.ReadLine();

            while (!double.TryParse(input, out resultat))
            {
                Console.WriteLine("Fejl, prøv igen");
                input = Console.ReadLine();
            }

            return resultat;
        }
        //Firkant arealet
        static double firkantareal(double længde, double bredde) 
        {
            double resultat;
            resultat = længde * bredde;
            return resultat;
        }
        //Trekant arealet
        static double Trekantareal(double højde, double gl)
        {
            double resultat;
            resultat = højde * gl / 2 ;
            return resultat;
        }
        static double cirkelareal(double radius)
        {
            double resultat;
            resultat = Math.PI * radius * radius;
            return resultat;
        }

        static void Main(string[] args)
        {
            //firkant

            double længde;
            double bredde;

            //Trekandt
            double højde;
            //gl = Grundlinge
            double gl;
           
            //Cirkel
            double radius;
            //svar = do while løkkens resultat.
            string svar;

            //resultat = resultatet fra udregningen
            double resultat;


            do
            {
                Console.WriteLine("Velkommen til Geometri");
                Console.WriteLine("I denne opgave kan du udregne arealet af en Firkant, Trekant og en Cirkel.");
                Console.WriteLine("Tast 1 for Firkant, Tast 2 for Trekant, Tast 3 for Cirkel,");
                Console.WriteLine();

                String str = Console.ReadLine();

                //bruger hvad Case bruger taster ind til at lave den udregning der skal laves
                switch (str)
                {
                    case ("1"):
                        //Firkant
                        længde = getintfromuser("Skriv længden på din firkant: ");
                        while (længde <= 0)
                        {
                            længde = getintfromuser("Skriv længden på din firkant, og det skal være et tal og ikke nul: ");
                        }
                        bredde = getintfromuser("Skriv bredden på din firkant: ");
                        while (bredde <= 0)
                        {
                            bredde = getintfromuser("Skriv bredden på din firkant, og det skal være et tal og ikke nul: ");
                        }
                        resultat = firkantareal(længde, bredde);
                        Console.WriteLine(resultat);

                        break;
                    case ("2"):
                        //Trekandt
                        længde = getintfromuser("Skriv længden på din Trekant: ");
                        while (længde <= 0)
                        {
                            længde = getintfromuser("Skriv længden på din Terkant, og det skal være et tal og ikke nul: ");
                        }
                        bredde = getintfromuser("Skriv bredden på din Trekant: ");
                        while (bredde <= 0)
                        {
                            bredde = getintfromuser("Skriv bredden på din Trekant, og det skal være et tal og ikke nul: ");
                        }
                        resultat = Trekantareal(længde, bredde );
                        Console.WriteLine(resultat);
                        break;
                    case ("3"):
                        //cirkel
                        radius = getintfromuser("Skriv radiusen på din cirkel: ");
                        while (radius <= 0)
                        {
                            radius = getintfromuser("Skriv radiusen på din cirkel, og det skal være et tal og ikke nul: ");
                        }
                        resultat = cirkelareal(radius);
                        Console.WriteLine(resultat);
                        
                        break;

                }
                Console.WriteLine("Ønser du at prøve igen? ja/nej");

                //Console.ReadLine(Læser Tekst fra Bruger);
                svar = Console.ReadLine();

            } while (svar == "J" || svar == "j" || svar == "ja" || svar == "Ja" || svar == "jA" || svar == "JA  ");
        }
    }
}
