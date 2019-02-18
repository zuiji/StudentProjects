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
            bool isLogIn = Opg1();

            if (!isLogIn)
            {
                return;
            }

            string[] BoysName = new string[20] {"William","Oliver","Noah","Emil","Victor","Magnus","Frederik","Mikkel","Lucas","Alexander","Oscar","Mathias","Sebastian","Malthe","Elias","Christian","Mads","Gustav","Villads","Tobias"};
            Console.WriteLine("You can do a partial search");
            String inputFromUser = Console.ReadLine();

            foreach (string i in BoysName)
            {
                if (i.Contains(inputFromUser))
                {
                    Console.WriteLine(i);
                    
                }
            }

        }

        private static bool Opg1()
        {
            #region Øvelse 1: login

            //arrays containing usernames and passwords, the index space in usernames corresponds to the index space in password
            string[] userNameArrays = new string[5] { "user1", "user2", "user3", "User4", "user5" };
            string[] passwordArrays = new string[5] { "pass1", "pass2", "pass3", "pass4", "pass5" };

            int guesses = 0;
            do
            {
                Console.WriteLine("Enter your UserName");
                string username = Console.ReadLine();
             
                for (int i = 0; i < userNameArrays.Length; i++)
                {
                    if (username == userNameArrays[i])
                    {
                        Console.WriteLine("Enter your Password");
                        string password = Console.ReadLine();
                        if (passwordArrays[i] == password)
                        {

                            Console.WriteLine("You have logged in");
                            guesses = 3;
                            return true;
                        }

                    }


                }
                
                Console.WriteLine("Your Username or Password are not Correct");
                guesses++;

            } while (guesses < 3);

            return false;
            #endregion
        }
    }
}