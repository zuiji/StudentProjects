using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valutaomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            double USDollers = 0.0684 * 1.5;
            double BritiskPound = 0.0831 * 1.5;
            double Euro = 0.0745 * 1.8;
            double Swedish = 0.7095 * 1.8;



            Console.WriteLine("Welcomen to Peter's Valuta Calculater\nHere you can see how much you get.\ndanish Krones into US Dollars, Britiske Pund, Euro and Swedish krona.\n");
            Console.WriteLine("how much you want to changes");
            double Danishkrones = double.Parse(Console.ReadLine());
            Console.WriteLine("For " + Danishkrones + " Danish Krones you get\n US Dollers = " + Danishkrones * USDollers + "\n Britisk Pound = " + Danishkrones * BritiskPound + "\n Euro = " + Danishkrones * Euro + "\n Swedisch krona = " + Danishkrones * Swedish);

            Console.ReadKey();
        }
    }
}
