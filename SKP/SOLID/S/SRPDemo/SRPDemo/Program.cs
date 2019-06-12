using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Before all changes its did look like this...

            //Console.WriteLine("welcome to my application");

            //// Ask for user information
            //Person user = new Person();

            //Console.Write("What is your first name: ");
            //user.FirstName = Console.ReadLine();

            //Console.Write("What is your last name: ");
            //user.LastName = Console.ReadLine();

            //// Checks to be sure the first and last name are valid
            //if (string.IsNullOrWhiteSpace(user.FirstName))
            //{
            //    Console.WriteLine("You did not give us a valid first name!");
            //    Console.ReadLine();
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(user.LastName))
            //{
            //    Console.WriteLine("You did not give us a valid last name!");
            //    Console.ReadLine();
            //    return;
            //}

            //// Create a username for the person

            //Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
            //Console.ReadLine();


            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();
        }
    }
}
