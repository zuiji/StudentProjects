using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rumfanget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intast højden på din kasse");
            double Hight = double.Parse(Console.ReadLine());

            Console.WriteLine("Intast breden på din kasse");
            double Wirght = double.Parse(Console.ReadLine());

            Console.WriteLine("indtast længten af din kasse.");
            double Lenth = double.Parse(Console.ReadLine());

            Console.WriteLine("Rumfanget af din kasse er : "+  Hight * Wirght * Lenth );

            Console.ReadKey();



        }
    }
}
