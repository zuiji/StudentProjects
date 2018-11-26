using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalisering
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1, tal2;
            double resultat;

            Console.Write("Indtast et heltal: ");
            while (!int.TryParse(Console.ReadLine(), out tal1))
            {
                Console.Write("Ugyldigt indput, prøv igen: ");
            }
            Console.Write("indtast et heltal, forskelligt fra null: ");
            while (!int.TryParse(Console.ReadLine(), out tal2) || tal2 == 0)
            {
                Console.Write("Ugyldigt input, prøv igen: ");
            }

            resultat = (double) tal1 / (double) tal2;

            Console.WriteLine("Første tal divideret meed andet tal er: " + resultat);
        }
    }
}
