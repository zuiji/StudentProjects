using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider_lomme_regner
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave fra Video 3 til opgave video 4.
        
            Start:
            Double num01;
            Double num02;

            Console.Write("Type a numer to be divided: ");
            num01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Type another nummber to be devided: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num01 + "divided by" + num02 + " is equal to " + num01 / num02);

            // Wait for the user to press a key. Then make empty space and start over.
            Console.ReadKey();
            Console.WriteLine();
            goto Start; //Jumps to "Start:".
        }
    }
}
