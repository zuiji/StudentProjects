using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Øvelse 6
            Console.WriteLine("Øvelse 6");

            //Ledetekst
            Console.Write("Indtast hvor mange tal du vil bruge til at finde gemmensnit: ");

            //Datafangst og konvertering til kommatal
            String a = Console.ReadLine();
            double bruger = double.Parse(a);

            double sum = 0;

            for (double tælleværdi = bruger; tælleværdi > 0; tælleværdi--)
            {
                //Ledetekst
                Console.Write("Indtast et tal: ");


                //Datafangst og konvertering til kommatal
                String str = Console.ReadLine();
                double tal = double.Parse(str);
                sum = sum + tal;
                
            }

            double resultat = sum / bruger;

            Console.WriteLine("Beregnet Gemmensnit " + resultat );

            Console.ReadKey();
        }

    }
}