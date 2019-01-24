using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gæt_et_Tal
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputFromUser;
            int tryFromUser = 1;
            do
            {

                Console.WriteLine("Hello " + System.Environment.UserName + "\nHere you need to guess a number between 1 and 10");
                Random random = new Random();
                int RollOfTheDice = random.Next(1, 10);

                inputFromUser = Convert.ToInt32(Convert.ToString(Console.ReadKey(false).KeyChar));
                while (inputFromUser != RollOfTheDice)
                {

                    if (RollOfTheDice < inputFromUser)
                    {
                        Console.WriteLine(" Sorry.. But your guess was wrong. try with a lower number");
                    }
                    else if (RollOfTheDice > inputFromUser)
                    {
                        Console.WriteLine(" Sorry.. But your guess was wrong. try with a higher number");
                    }
                    inputFromUser = Convert.ToInt32(Convert.ToString(Console.ReadKey(false).KeyChar));
                    tryFromUser++;
                }

                Console.WriteLine(" Hurra..! you did guess the number\n You used " + tryFromUser + " guess");


                tryFromUser++;
            } while (false);

            Console.ReadKey();

        }
    }
}
