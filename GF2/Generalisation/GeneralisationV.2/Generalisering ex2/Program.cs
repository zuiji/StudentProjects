using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalisering_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1, tal2;
            double resultat;
            tal1 = GetIntFromUser("Indtast et heltal: ");
            tal2 = GetIntFromUser("indtast et heltal, forskelligt fra nul: ");
            while (tal2 == 0)
            {
                tal2 = GetIntFromUser("Indtast et heltal, forskelligt fra nul: ");
            }

            resultat = (double)tal1 / (double)tal2;
            Console.WriteLine("Første tal divideret med antal tal er: " + resultat);

        }
        static int GetIntFromUser(string Spørgsmål1)
        {
            Console.WriteLine(Spørgsmål1);
            string input;
            int resultat;
            input = Console.ReadLine();
            while (!int.TryParse(input, out resultat))
            {
                Console.WriteLine("Ups, der skete en fejl prøv med et tal i stedet");
                input = Console.ReadLine();
            }

            return resultat;

        }
    }
}
