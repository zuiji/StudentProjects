using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom___CRP_check
{
    class CPRCheck
    {
        public static void
        RunCPRCheck()
        {
            int Retirment = 70;
            Console.WriteLine("Please Insert your CPR as YYYY MM DD SSSS");
            List<int> Numbers = new List<int>();
            do
            {
                int input;
                bool parsesuccess = int.TryParse(Console.ReadLine(), out input);
                if (parsesuccess)
                {
                    Numbers.Add(input);

                }
                else
                {
                    Console.WriteLine("Error wrong sort Please try again.");
                }
            } while (Numbers.Count < 4);
           DateTime birthday = new DateTime(Numbers[0], Numbers[1], Numbers[2]);

            if (Numbers[3] % 2 == 0)
            {
                int Age = DateTime.Today.Year - birthday.Year;
                if (birthday.AddYears(Age) > DateTime.Today)
                {
                    Age--;
                }

                Console.WriteLine("You are " + Age + " Years old\n You are a Girl\nYou can go on Retirement in " + (Retirment - Age) + " Years");
                
            }
            else
            {
                int Age = DateTime.Today.Year - birthday.Year;
                if (birthday.AddYears(Age) > DateTime.Today)
                {
                    Age--;
                }

                Console.WriteLine("You are " + Age + " Years Old\nYou are a Boy\nYou can go on Retirement in " + (Retirment - Age) + " Years");
            }
            Console.ReadKey();
        }
        

    }

}
