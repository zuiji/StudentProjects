using System;
using System.CodeDom;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            #region Login

            // In here we do a check as log isLogIn is True you will be able to do next exercise.

            bool isLogIn = Opg1();

            if (!isLogIn)
            {
                return;
            }

            //Calling PauseAndClear
            PauseAndClear();
            #endregion
            

            // Calling Opg2And3 method.
            Opg2And3();

            // Calling PauseAndClear
            PauseAndClear();

            float[,] punctuations = new float[10, 10];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Enter the punctuation {0} group {1}: ", j + 1, i + 1);
                    punctuations[i, j] = Convert.ToSingle(Console.ReadLine());
                }
            }

            // Calling PauseAndClear
            PauseAndClear();


            for (int i = 0; i < 2; i++)
            {
                float avg = 0;
                for (int j = 0; j < 10; j++)
                {
                    avg += punctuations[i, j];
                }

                Console.WriteLine($"Average in punctuation {i + 1}: {avg / 10}");
            }

        }
        private static bool Opg1()
        {
            #region Øvelse 1: login

            //string arrays containing usernames and passwords, the index space in usernames corresponds to the index space in password
            string[] userNameArrays = new string[5] { "user1", "user2", "user3", "User4", "user5" };
            string[] passwordArrays = new string[5] { "pass1", "pass2", "pass3", "pass4", "pass5" };

            //Variable int guesssis used for count.
            int guesses = 0;

            //Keeps Running until Guesses returns true or false.
            do
            {
                //writes out to user
                Console.WriteLine("Enter your UserName");

                // reads users input
                string username = Console.ReadLine();

                //loops and read if the user and password are correct
                for (int i = 0; i < userNameArrays.Length; i++)
                {
                    //checking if username mach one in the Array and if it does its asks for password. else its returns error 
                    if (username == userNameArrays[i])
                    {
                        //writes to user
                        Console.WriteLine("Enter your Password");

                        // reads user input
                        string password = Console.ReadLine();

                        // checks if password mach Name arrays index and if its does its log you in. 
                        if (passwordArrays[i] == password)
                        {
                            //writes to user
                            Console.WriteLine("You have logged in");

                            //sets guesses to 3 and returns True with allows you to login. 
                            guesses = 3;
                            return true;
                        }

                    }


                }
                //Write to user
                Console.WriteLine("Your Username or Password are not Correct");

                //adds +1 to guesses variable
                guesses++;

                //stops if it hit 3 and returns false with does you cant login. 
            } while (guesses < 3);

            //returns you used to many try-es
            return false;
            #endregion
        }

        private static string[] Opg2(string[] boysName)
        {/// <summary>
         ///
         /// denne opgave indholder 20 drengenavne som bliver udskrevet i alfabetisk orden og kan søges via bokstaver fra inPutFromUser
         /// 
         /// BoysNames = boysname.orderBy(i = objected i Boysname fx "Noah" => i )
         /// .where( x = objected i Boysname fx "Noah" => x.ToLower() laver alt til lowerCaces. Contains kigger efter ( inPutFromUser )).ToArray(); putter tingene i et array.
         /// </summary>
         /// <param name="boysName"></param>
            Console.Clear();
            Console.WriteLine("You can do a partial search");
            string inputFromUser = Console.ReadLine().ToLower();

            string[] boysNames = boysName.OrderBy(i => i).ToArray();

            foreach (string s in boysNames.Where(x => x.ToLower().Contains(inputFromUser)))
            {
                Console.WriteLine(s);
            }

            return boysNames;
        }

        private static void Opg2And3()
        {
            // string Array that size are 20 and contains Boy names
            string[] boysName = new string[20]
            {
                "William", "Oliver", "Noah", "Emil", "Victor", "Magnus", "Frederik", "Mikkel", "Lucas", "Alexander", "Oscar",
                "Mathias", "Sebastian", "Malthe", "Elias", "Christian", "Mads", "Gustav", "Villads", "Tobias"
            };

            // string Array that size are 20 and contains girl names
            string[] girlName = new string[20]
            {
                "Ann", "Helle", "Aloha", "Fe", "Gift", "Mynte", "Myrtille", "Krushbakht", "Rikkepippih", "Lisa", "Yrsavickie",
                "Lise", "Tigerlilly", "Ninja", "Musling", "Jytta", "Europa", "Altan", "Lilly", "Josephine"
            };

            //creating new array list. 
            ArrayList nameArrayList = new ArrayList();

            //name array list.add range(Opg2(boysName)); adds the to array boysName 
            nameArrayList.AddRange(Opg2(boysName));

            // calls Opg3 and sends nameArrayList and girlName to Opg3
            Opg3(nameArrayList, girlName);
        }

        private static void Opg3(ArrayList nameArrayList, string[] girlName)
        {

            
            bool stop = false;

            //keeps running til stop are true.
            do
            {   
                //calls pauseAndClear
                PauseAndClear();

                //Writes to user
                Console.WriteLine("Opg3 Delete Username From List");
                Console.WriteLine("Press 1 for Delete Name");
                Console.WriteLine("Press 2 for Add Name");
                Console.WriteLine("Press 3 to add Women Names");
                Console.WriteLine("press anything else to continue");

                //reading users input. 
                char inputFromUser = Console.ReadKey(true).KeyChar;

                //gives user some options
                switch (inputFromUser)
                {   
                    //option
                    case '1':

                        //calls method and send nameArraylist with it. 
                        nameArrayList = Opg3DeleteName(nameArrayList);

                        // break so its can continue
                        break;

                    //option 
                    case '2':

                        //calls method and send nameArrayList with it.
                        nameArrayList = Opg3AddName(nameArrayList);

                        //breaks
                        break;

                    //option
                    case '3':

                        //calls method and sends girlName with it.
                        nameArrayList.AddRange(girlName);


                        //runs truth the nameArrayList and writes it out to the user. 
                        foreach (object o in nameArrayList)
                        {
                            //writes out to user.
                            Console.WriteLine(o);
                        }

                        //breaks
                        break;
                    default:
                        stop = true;
                        break;
                }
            } while (!stop);
        }

        private static ArrayList Opg3AddName(ArrayList boysNameArrayList)
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

        private static ArrayList Opg3DeleteName(ArrayList boysNameArrayList)
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

        private static void PauseAndClear()
        {
            /// <summary>
            /// 
            /// PauseAndClear is a Method that clear the console and waits for the an UserInput.
            ///
            /// </summary>
            Console.WriteLine("Press any Button to Continue");
            Console.ReadKey(true);
            Console.Clear();
        }


    }
}