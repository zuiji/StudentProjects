using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GetRandom
{
    class Program
    {

        static void Main(string[] args)
        {
            int inputFromUser = 0;
            int tryFromUser = 1;
            do
            {

                Console.WriteLine("Hej " + System.Environment.UserName + "\nher skal du gætte et tal mellem 1 og 10");
                Random random = new Random();
                int terningskast = random.Next(1, 10);
               
                inputFromUser = Convert.ToInt32(Convert.ToString(Console.ReadKey(false).KeyChar));
                while (inputFromUser != terningskast)
                {

                    if (terningskast < inputFromUser)
                    {
                        Console.WriteLine(" Øv Tallert var for højt prøv igen med et lavere tal");
                    }
                    else if (terningskast > inputFromUser)
                    {
                        Console.WriteLine(" Øv Tallet var forlavt prøv igen med et højre tal");
                    }
                    inputFromUser = Convert.ToInt32(Convert.ToString(Console.ReadKey(false).KeyChar));
                    tryFromUser++;
                }

                Console.WriteLine(" Hurra du har gættet rigtigt\n Du brugte " + tryFromUser + " gæt");


                tryFromUser++;
                ;
            } while (false);

            Console.ReadKey();
        }
    }
}
