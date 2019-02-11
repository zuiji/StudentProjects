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
            string[] Lines = new string[1000000];
            Random rand = new Random();

            for (int i = 0; i < 1000000; i++)
            {
                Lines[i] = $"{i},{rand.Next(0, 10000)}";
            }
            File.WriteAllLines(@".\Numberlist.txt",Lines);
        }
    }
}
