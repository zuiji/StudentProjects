using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nysgerrige_spørgsmål
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Old are you? ");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("How high are you in cm?");
            int high = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("how much is your withe?");
            double withe = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"You are {age} years old, you are {high} cm high And your withe is {withe} kg");

        }
    }
}
