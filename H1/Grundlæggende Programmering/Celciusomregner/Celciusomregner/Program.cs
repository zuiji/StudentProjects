using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celciusomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summery>
            ///
            /// Skriv et program som omregner Celciusgrader til Fahrenheit- og Reamurgrader. Celciusgraden skal indlæses fra konsolvinduet og resultaterne skal også udskrives til konsolvinduet.
            ///
            /// Formlen for omregningen
            ///
            /// Reamur = Celcius * 0.8
            /// Fahrenheit = Celcius * 1.8 + 32
            ///
            /// Eksempel på indlæsning fra konsollen
            /// double c = double.Parse(Console.ReadLine());
            /// double.Parse forsøger at omdanne det der kommer fra konsollen til en doubleværdi
            /// </summery>
            
            
            // Console.WriteLine sends a text to the command box
            Console.WriteLine("hvor varmt er det uden for?");

            //double Celcius is my variable that can hold decimals
            //Double.parse(Console.ReadLine()); convotes a string to decimals. 
            double Celcius = Double.Parse(Console.ReadLine());

            // Console.WriteLine sends a text to the command box
            Console.WriteLine("så var er det i\n" + "Reamur = " + Celcius * 0.8 + "\nFahrenhite = " + (Celcius * 1.8 + 32));

            //Waits for user Input
            Console.ReadKey();

        }
    }
}
