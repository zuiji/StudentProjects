using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terningkastet
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.Yellow;
            Random random = new Random();
            int terningskast = random.Next(1, 7);

            if (terningskast == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du slog en etter");
            }
            else if (terningskast == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du slog en to'er");
            }
            else if (terningskast == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Du slog en tre'er");
            }
            else if (terningskast == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Du slog en fire'er");
            }
            else if (terningskast == 5)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Du slog en fem'er");
            }
            else if (terningskast == 6)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Do slog en seks'er");
            }

            Console.ReadKey();
        }
    }
}
