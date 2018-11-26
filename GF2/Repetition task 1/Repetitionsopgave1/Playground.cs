using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Repetitionsopgave1
{
    static class Playground
    {
        public static void
            RunPlayground()
        {
            char inputFromUser;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Clear();
            do
            {
                Console.WriteLine("Vælg en af de følgende valg muligheder");
                /*
                /t = tabtast
                /n = ny linje
                char = 1 karkter
                inputFromUser = brugerens indtastning som char
                */
                Console.WriteLine("1)\tVurdering af tal \n2)\tUdskriv liste af lige tal \n3)\tAlder \n4)\tAfslut");

                inputFromUser = Console.ReadKey(true).KeyChar;

                switch (inputFromUser)
                {
                    case '1':
                        inputFromUser = Choice1();
                        Clear();
                        break;
                    case '2':
                        inputFromUser = Choice2();
                        Clear();
                        break;
                    case '3':
                        inputFromUser = Choice3();
                        Clear();
                        break;
                    case '4':
                        break;
                    default:
                        Clear();
                        Console.WriteLine("Fejl. Prøv Tal mellem 1-4");
                        break;
                }
            } while (inputFromUser != '4');
        }

        /*
            Lenth = Count i en list
            Lenth = Bruges i et Array
            count <4 stopper efter 4 tal.
            %2==0 = Bliver kun sandt hvis tallet giver lige tal. 
        */
        public static char Choice1()
        {
            int inputFromUser;
            Console.WriteLine("indtast 4 heltal tryk enter for næste tal.");
            List<int> numbers = new List<int>();
            do
            {
                bool parsesuccess = int.TryParse(Console.ReadLine(), out inputFromUser);
                if (parsesuccess)
                {
                    numbers.Add(inputFromUser);
                }
                else
                {
                    Console.WriteLine("Fejl. Det lykkedes ikke, Prøv igen");
                }
            } while (numbers.Count < 4);
            int[] arr1 = new int[] { 0, 0, 0, 0 };

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    arr1[0]++;
                }
                else
                {
                    arr1[1]++;
                }

                if (number > 100)
                {
                    arr1[2]++;
                }

                if (number < 0)
                {
                    arr1[3]++;
                }
            }

            Console.WriteLine("du har " + arr1[0] + " tal som er lige");
            Console.WriteLine("du har " + arr1[1] + " tal som er ulige");
            Console.WriteLine("du har " + arr1[2] + " tal som er større end 100");
            Console.WriteLine("du har " + arr1[3] + " tal som er negative :-(\n");
            Console.WriteLine("Tryk 4 for at afslutte og alt andet for at komme tilbage til menuen");

            return Console.ReadKey(true).KeyChar;
        }

        /*
            Lenth = Count i en list
            Lenth = Bruges i et Array
            count <2 stopper efter 2 tal.
        */

        public static char Choice2()
        {
            int inputFromUser;
            Console.WriteLine("indtast 2 heltal tryk enter for næste tal.");
            List<int> numbers = new List<int>();
            do
            {
                bool parsesuccess = int.TryParse(Console.ReadLine(), out inputFromUser);
                if (parsesuccess)
                {
                    numbers.Add(inputFromUser);
                }
                else
                {
                    Console.WriteLine("Fejl. Det lykkedes ikke, Prøv igen");
                }
            } while (numbers.Count < 2);

            Console.Write("Lige Tal( ");
            int biggest = Math.Max(numbers[0], numbers[1]);
            int smallest = Math.Min(numbers[0], numbers[1]);

            for (int i = smallest + 1; i < biggest; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "  ");
                }
            }
            Console.Write(")\n");
            Console.WriteLine(smallest + " går op i " + biggest + " " + biggest / smallest + " gange");
            Console.WriteLine("Tryk 4 for at afslutte og alt andet for at komme tilbage til menuen");
            return Console.ReadKey(true).KeyChar;
        }

        public static char Choice3()
        {
            int inputFromUser;
            Console.WriteLine("indtast din fødselsdato som 3 tal, år, månede, og dag ex. 2018 01 01\n tryk enter for næste tal.");
            List<int> numbers = new List<int>();
            do
            {
                bool parsesuccess = int.TryParse(Console.ReadLine(), out inputFromUser);
                if (parsesuccess)
                {
                    numbers.Add(inputFromUser);
                }
                else
                {
                    Console.WriteLine("Fejl. Det lykkedes ikke, Prøv igen");
                }
            } while (numbers.Count < 3);

            DateTime birthday = new DateTime(numbers[0], numbers[1], numbers[2]);

            int Age = DateTime.Today.Year - birthday.Year;
            if (birthday.AddYears(Age) > DateTime.Today)
            {
                Age--;
            }

            Console.WriteLine("Din alder er " +Age);

            Console.WriteLine("Tryk 4 for at afslutte og alt andet for at komme tilbage til menuen");
            return Console.ReadKey(true).KeyChar;
        }

        public static void Clear()
        {
            /*        
            4system.environment.username udskriver brugerens login name fra pc.   
            */
            Console.Clear();
            Console.WriteLine(System.Environment.UserName + "\n");
        }
    }
}
