using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom___CRP_check
{   
    class palindrom
    {
        public static void
            Palindrom()
        {
            string input;
            int firstchar = 0;
            int lastchar;
            bool RunProgram = (true);
            string output = "";

            Console.WriteLine("Write a word and the program will check if its spelled the same way from behind.");
            input = Console.ReadLine().ToLower();
            lastchar = input.Length;
            lastchar--;

            do
            {
                if (input[firstchar] == input[lastchar])
                {
                    output += input[firstchar];
                    firstchar++;
                    lastchar--;
                }

                else
                {
                    RunProgram = false;
                    Console.WriteLine("This is not at palindrome");
                }

                if (firstchar == input.Length)
                {
                    Console.WriteLine(" | " + output + " |is a palindrome");
                    RunProgram = false;
                }
            } while (RunProgram);

            Console.ReadKey();
        }
    }
}
