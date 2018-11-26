using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace metoder_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Main");
            Metode1();
            Console.WriteLine("Slut Main");
            Console.ReadLine();
        }
        
        public static void Metode1()
        {
            Console.WriteLine("Start Metode1");
            Metode2();
            Console.WriteLine("Slut Metode1");
        }

        public static void Metode2()
        {
            Console.WriteLine("Start Metode2");
            Metode3();
            Console.WriteLine("Slut Metode2");
        }

        public static void Metode3()
        {
            Console.WriteLine("Start Metode3");
            Console.WriteLine("Slut Metode3");
        }
    }
}


