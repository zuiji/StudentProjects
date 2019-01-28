using System;
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

            bool nameCheck = true;
            string[] userNameArrays = new string[5] { "user1", "user2", "user3", "User4", "user5" };
            string[] passwordArrays = new string[5] { "pass1", "pass2", "pass3", "pass4", "pass5" };

            Console.WriteLine("Enter your UserName");
            string username = Console.ReadLine();

            do
            {

                for (int i = 0; i < userNameArrays.Length; i++)
                {
                    if (username == userNameArrays[i])
                    {
                        Console.WriteLine("Enter your Password");
                        string password = Console.ReadLine();

                        for (int count = 3; count > 0; count--)
                        {
                            if (password != passwordArrays[i])
                            {

                                Console.WriteLine("Username or Password don't match");
                            }
                            if (password == passwordArrays[i])
                            {
                                Console.WriteLine("you are logged in.");
                                count = 0;
                            }
                        }

                        while (nameCheck != false)
                        {
                            for (int count = 3; count > 0; count--)
                            {
                                if (password != passwordArrays[i])
                                {

                                    Console.WriteLine("Username or Password don't match");
                                }
                                if (password == passwordArrays[i])
                                {
                                    Console.WriteLine("you are logged in.");
                                    count = 0;
                                }
                            }

                        }
                    } 


                }

            } while (nameCheck == true);


        }
    }
}
