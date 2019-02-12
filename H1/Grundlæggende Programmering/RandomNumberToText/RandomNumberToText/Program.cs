using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            //string array med plads til 10000001 array pladser
            string[] Lines = new string[1000001];

            //random fabrikken
            Random rand = new Random();

            //forløkken som generer random nummer og putter dem i arrayet
            for (int i = 0; i <= 1000000; i++)
            {
                Lines[i] = $"{i},{rand.Next(0, 9999)}";
            }

            //skriver talen til txt til
            File.WriteAllLines(@".\Numberlist.txt",Lines);
        }
    }
}
