using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("intast dit navn");
            string Navn = Console.ReadLine();
            Console.WriteLine("intast din alder");
            double Alder = double.Parse(Console.ReadLine());

            if (Alder <= 3)
            {
                Console.WriteLine(Navn + " , du må gå med ble");
            }

            else if (Alder >= 4 && Alder <= 15)
            {
                Console.WriteLine(Navn + ", du må ingenting");
            }

            else if (Alder >= 15 && Alder < 18)
            {
                Console.WriteLine(Navn + ", du må drikke");
            }
            else if (Alder >= 18)
            {
                Console.WriteLine(Navn + " ,du må stemme og køre bil");
            }

            Console.ReadKey();
        }
    }
}
