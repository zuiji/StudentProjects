using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            Opg1();
        }

        private static void Opg1()
        {
            #region Øvelse 1: login

            //arrays containing usernames and passwords, the index space in usernames corresponds to the index space in password
            string[] userNameArrays = new string[5] { "user1", "user2", "user3", "User4", "user5" };
            string[] passwordArrays = new string[5] { "pass1", "pass2", "pass3", "pass4", "pass5" };

            bool answers = true;
            do
            {
                Console.WriteLine("Enter your UserName");
                string username = Console.ReadLine();

                for (int i = 0; i < userNameArrays.Length; i++)
                {
                    if (username == userNameArrays[i])
                    {
                        Console.WriteLine("Enter your Password");

                    }
                }
                string password = Console.ReadLine();

                for (int j = 0; j < passwordArrays.Length; j++)
                {
                    if (password != passwordArrays[j]) ;
                    
                }

                foreach (string k in userNameArrays)
                {
                    foreach (string l in passwordArrays)
                    {
                        if (k == l)
                        {
                            Console.WriteLine("You have logged in");

                        }
                        /*else if (k != l)
                        {

                            Console.WriteLine("Try again.");

                        }*/
                        else
                        {
                            Console.WriteLine("Your Username or Password are not Correct");
                        }

                    }

                }
                
            } while (true);
            #endregion
        }
    }


}
