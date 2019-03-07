using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(1.25);
            Console.WriteLine(sq.Perimeter());
            Square sq1 = new Square(2.5);
            Console.WriteLine(sq1.Perimeter());

            Console.WriteLine(sq.area());

            sq.sides = 250;
            sq1.sides = 500;

            Console.WriteLine(sq.Perimeter());
            Console.WriteLine(sq1.area());
        }
    }
}
