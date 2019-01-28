using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("intast første tal");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("intast andet tal");
            double b = double.Parse(Console.ReadLine());
            double c = ((a * a) + (b * b));
            Console.WriteLine("Dit Pythagoras er " + ("tal1 = " + a + "² tal2 =  " + b + "² = " + c + "² C = " + Math.Sqrt(c)));
            if (a > b)
            {
                Console.WriteLine("A er størst");
            }
            else if (a < b)
            {
                Console.WriteLine("B er størst");
            }
            else
            {
                Console.WriteLine("A og B er lige store");
            }
            Console.ReadKey();
        }
    }
}
