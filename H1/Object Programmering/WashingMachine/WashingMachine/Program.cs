using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer Machine = new Washer();

            Machine.Fill();


            Console.ReadKey();

        }
    }
}
