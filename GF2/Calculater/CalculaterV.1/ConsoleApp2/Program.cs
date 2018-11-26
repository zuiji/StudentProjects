using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            //float deimalpoint = 10.4;
            //bool trueOrFalse = true;
            //string sentence = "Hello World!";
            int num02;
            //int result; Ændres til hvis man ska lave Minus Stykker



            Console.Write("Type a numer to be multiplid: ");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type another nummber: ");
            num02 = Convert.ToInt32(Console.ReadLine());
            
            //result = num01 - num02;  slut berening hvis man skal lave minus
                       
            Console.WriteLine("The Result is " + num01 * num02);

            Console.ReadKey();
        }


    }
}
