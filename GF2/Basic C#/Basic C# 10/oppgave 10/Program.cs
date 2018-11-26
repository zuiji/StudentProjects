using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppgave_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable
            string svar;
            double sum = 0;

            //do While løkke kører så længe bruger taster ("j eller J")
            do
            { //Console.WriteLine(Skriver Tekst til Bruger);
                Console.WriteLine("Hej her er en lille lommeregner.");
                Console.WriteLine("Den virker som en normal lommeregner.");
                Console.WriteLine("Skriv et tal");

                //Datafangst og konvertering til kommatal
                String a = Console.ReadLine();
                double tal1 = double.Parse(a);

                //Datafangst af operator
                Console.WriteLine("Vælg operator");
                String str = Console.ReadLine();

                Console.WriteLine("Skriv et tal 2");
                //Datafangst og konvertering til kommatal
                string b = Console.ReadLine();
                double tal2 = double.Parse(b);

                //bruger hvad Case bruger taster ind til at lave den udregning der skal laves
                switch (str)
                {
                    case ("+"):
                        sum = tal1 + tal2;
                        break;
                    case ("-"):
                        sum = tal1 - tal2;
                        break;
                    case ("*"):
                        sum = tal1 * tal2;
                        break;
                    case ("/"):
                        sum = tal1 / tal2;
                        break;
                }
                //variable
                double resultat = sum;

                //Console.WriteLine(Skriver Tekst til Bruger);
                Console.WriteLine(resultat);
                Console.WriteLine("Ønser du at prøve igen? j/n");

                //Console.ReadLine(Læser Tekst fra Bruger);
                svar = Console.ReadLine();

            } while (svar == "J" || svar == "j");

        }
    }
}

