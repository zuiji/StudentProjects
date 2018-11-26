using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            String tmp = ("´´´´");
            Console.WriteLine("Skrive en tekst og tryk enter");
            tmp = Console.ReadLine();
            Console.WriteLine("Du skrev " + tmp);
            Console.ReadKey();
        }
    }
}
