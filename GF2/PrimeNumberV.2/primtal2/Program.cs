using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primtal2
{
    class Program
    {
        static void Main(string[] args)
        {
            int antal = 0;
            bool Primtal = true;
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        Primtal = false;
                        break;
                    }


                }
                if (Primtal)
                {
                    antal++;
                    Console.Write("\t" + i);
                }
                Primtal = true;
            }

            Console.WriteLine();
            Console.WriteLine(antal);
            Console.ReadKey();
        }
    }
}
