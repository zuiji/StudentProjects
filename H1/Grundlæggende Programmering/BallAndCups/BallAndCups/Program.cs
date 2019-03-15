using System;

namespace BallAndCups
{
    class Program
    {

        static void Main(string[] args)
        {
            int inputFromUser = '0';
            do
            {


                Random r = new Random();
                int ran = r.Next(1, 3);

                Console.WriteLine("Lets play Ball and Cups");
                Console.WriteLine("Where does the ball hide?");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" # ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" # ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" # \n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" 1  2  3");

                //Console.WriteLine(ran);

                inputFromUser = Convert.ToInt32(Convert.ToString(Console.ReadKey(true).KeyChar));
                if (inputFromUser != ran)
                {
                    Console.WriteLine("sorry you did lose\nBetter Luck next time.");
                    Console.WriteLine("want to try again? if so Press { 0 } ");

                }
                else
                {
                    Console.WriteLine("Congrats you did win");
                    Console.WriteLine("want to try again? if so Press { 0 } ");

                }
                inputFromUser = Console.ReadKey(true).KeyChar;

            } while (inputFromUser == '0');
        }
    }
}
