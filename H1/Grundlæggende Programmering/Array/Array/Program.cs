using System;
using System.CodeDom;
using System.Collections;
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
            //#region Login
            //bool isLogIn = Opg1();

            //if (!isLogIn)
            //{
            //    return;
            //} 
            //#endregion

            string[] BoysName = new string[20] { "William", "Oliver", "Noah", "Emil", "Victor", "Magnus", "Frederik", "Mikkel", "Lucas", "Alexander", "Oscar", "Mathias", "Sebastian", "Malthe", "Elias", "Christian", "Mads", "Gustav", "Villads", "Tobias" };


            ArrayList boysNameArrayList = new ArrayList();
            boysNameArrayList.AddRange(Opg2(BoysName));
            Console.WriteLine("Press any Button to Continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Opg3 Delete Username From List");
            Console.WriteLine("Press 1 for Delete Name");
            Console.WriteLine("Press 2 for Add Name");
            Console.WriteLine("Press 3 to add a Women Name");
            char inputFromUser = Console.ReadKey(true).KeyChar;
            switch (inputFromUser)
            {
                case '1':
                    boysNameArrayList = DeleteNameFromOpg3(boysNameArrayList);
                    break;
                case '2':
                    boysNameArrayList = AddNameFromOpg3(boysNameArrayList);
                    break;
                case '3':
                    break;
            }
            

        }
        /// <summary>
        ///
        /// denne opgave indholder 20 drengenavne som bliver udskrevet i alfabetisk orden og kan søges via bokstaver fra inPutFromUser
        /// 
        /// BoysNames = boysname.orderBy(i = objected i Boysname fx "Noah" => i )
        /// .where( x = objected i Boysname fx "Noah" => x.ToLower() laver alt til lowerCaces. Contains kigger efter ( inPutFromUser )).ToArray(); putter tingene i et array.
        /// </summary>
        /// <param name="BoysName"></param>
        private static string[] Opg2(string[] BoysName)
        {
            Console.Clear();
            Console.WriteLine("You can do a partial search");
            String inputFromUser = Console.ReadLine().ToLower();

            string[] BoysNames = BoysName.OrderBy(i => i).ToArray();

            foreach (string s in BoysNames.Where(x => x.ToLower().Contains(inputFromUser)))
            {
                Console.WriteLine(s);
            }

            return BoysNames;
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

        private static ArrayList DeleteNameFromOpg3(ArrayList boysNameArrayList)
        {
            Console.WriteLine("What name will you delete from the List\n");



            for (int i = 0; i < boysNameArrayList.Count; i++)
            {
                Console.WriteLine($"{i} { boysNameArrayList[i]}");
            }

            Console.WriteLine();
            int inputFromUser = Convert.ToInt32(Console.ReadLine());
            boysNameArrayList.RemoveAt(inputFromUser);

            foreach (object o in boysNameArrayList)
            {
                Console.WriteLine(o);
            }

            return boysNameArrayList;
        }

        private static ArrayList AddNameFromOpg3(ArrayList boysNameArrayList)
        {
            Console.WriteLine("What name will you add from the List\n");

            string inputFromUser = Console.ReadLine();
            boysNameArrayList.Add(inputFromUser);
            Console.WriteLine();
            

            foreach (object o in boysNameArrayList)
            {
                Console.WriteLine(o);
            }

            return boysNameArrayList;
        }


    }
}