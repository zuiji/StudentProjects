using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;


namespace Miljø_AD_tool
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionPath.CreateDirectoryEntry();

            Console.WriteLine("Press 1 to read userinfo :\nPress 2 to addUser :\nPress 9 to stop : ");
            char inputFromUser = Console.ReadKey(true).KeyChar;
            switch (inputFromUser)
            {
                case '1':

                    Console.Write("Enter user: ");
                    string username = Console.ReadLine();
                    GetUserInfo.UserInfo(username, ConnectionPath.CreateDirectoryEntry());
                    break;

                case '2':
                    // Asking for Users First name and last name 
                    Console.WriteLine("Please enter Firstname");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Please enter LastName");
                    string lastname = Console.ReadLine();

                    // Calls method and sending variables.
                    CreateUser.CreateUserAccount(firstName, lastname, ConnectionPath.CreateDirectoryEntry());
                    break;

                case '9':
                    Console.WriteLine("To bad to see you go.\nHave a nice day");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong KeyChar try with 1 - 3, Please :') ");
                    break;
            }
        }
    }
}