using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave9
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            string svar;
            double sum = 0;

            //do While ( Løkke der bliver ved hvis Bruger Svare ("j eller J")
            do
            { //Console.WriteLine(Skriver Tekst til Bruger);
                Console.WriteLine("Hej her er en lille lommeregner.");
                Console.WriteLine("Den virker som en normal lommeregner.");
                Console.WriteLine("skriv et tal");

                //Datafangst og konvertering til kommatal
                String a = Console.ReadLine();
                double tal1 = double.Parse(a);

                //Console.WriteLine (Skriver tekst til Bruger)
                Console.WriteLine("skriv et tal 2");
                //Datafangst og konvertering til kommatal
                string b = Console.ReadLine();
                double tal2 = double.Parse(b);

                //Console.WriteLine(Skriver Tekst til Bruger);
                Console.WriteLine("Vælg operator");

                //Datafangst og konvertering til hvad der skal ske på komandoen.
                String str = Console.ReadLine();

                //if (Søger efter komandoen som bruger har indtastet og bruger den komando til hvad opgade den skal udføre.)
                if (str == "+")
                {
                    sum = tal1 + tal2;
                }
                else if (str == "-")
                {
                    sum = tal1 - tal2;
                }
                else if (str == "*")
                {
                    sum = tal1 * tal2;
                }
                else if (str == "/")
                {
                    sum = tal1 / tal2;
                }

                //variable
                double resultat = sum;

                //Console.WriteLine (Skriver tekst til bruger)
                Console.WriteLine(resultat);
                Console.WriteLine("Ønser du at prøve igen? j/n");

                //Console.ReadLine (Læser Bruger indput)
                svar = Console.ReadLine();
                
            } while (svar == "J" || svar == "j");
        }
    }
}
