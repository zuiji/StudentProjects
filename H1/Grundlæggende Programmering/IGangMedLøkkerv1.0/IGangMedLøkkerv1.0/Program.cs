using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGangMedLøkkerv1._0
{
    class Program
    {// This is a forloop thats count up from 0 to 100
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                // here its only type out to the user as long the numbers are lower then 50
                if (i < 50)
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey();
        }
    }

}
