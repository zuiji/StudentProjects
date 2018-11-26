using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BumLeg
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             opgave 
             1: Gennemløb 1-100 udskrives på ny linge
             2: Hvis 3 Går op i tallet: Bum
             3: Hvis 5 Går op i tallet: Lum
             4 hvis 3 og 5 går op i tallet : Bummelum
             */

            /*
            Console.WriteLine("Hej " + System.Environment.Username + "\n");
            udskriver navent på Computerens bruger.
            */
            Console.WriteLine("Hej " + System.Environment.UserName + "\n");

            /*
            for (int i = 1; i <= 100; i++)
            kalder tallende 1 - 100
            */
            for (int i = 1; i <= 100; i++)
            {

                /*
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("bummelum\n");
                }
                \n begyder ny linje
                i denne if lykke udskriver den bummelum i tilfældet af at tallert 3 og 5 går op i det og har en slut værdi 0
                */

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("bummelum\n");
                }

                /*
                if (i % 3 == 0 )
                {
                    Console.Write("bum\n");
                }
                \n begyder ny linje
                i denne if lykke udskriver den bummelum i tilfældet af at tallert 3 går op i det og har en slut værdi 0
                */

                else if (i % 3 == 0)
                {
                    Console.Write("bum\n");
                }

                /*
                else if (i % 5 == 0)
                {
                    Console.Write("lum\n");
                }
                i denne if lykke udskriver den bummelum i tilfældet af at tallert 5 går op i det og har en slut værdi 0
                */

                else if (i % 5 == 0)
                {
                    Console.Write("lum\n");
                }
                /*
                else
                {
                    Console.WriteLine(i +":");
                }    
                 i denne if lykke udskriver den næste tal i tilfældet af at hverken 3 eller 5 går op i tallet med slut værdi 0
                */
                else
                {
                    Console.WriteLine(i + ":");
                }
            }           
            /*
            Console.WriteLine("Hej " + System.Environment.Username + "\n");
            udskriver navent på Computerens bruger.
            */
            Console.WriteLine("Hej " + System.Environment.UserName + " nu er programmet færdig\n");
            Console.ReadKey();
        }
    }
}
