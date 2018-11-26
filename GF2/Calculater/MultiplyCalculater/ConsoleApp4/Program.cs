using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 12;

            while (a < b)
            {
                Console.WriteLine("In the loop");
                a += 2;
                b -= 2;
            }
            Console.ReadKey();      
        }
    }
    
}
