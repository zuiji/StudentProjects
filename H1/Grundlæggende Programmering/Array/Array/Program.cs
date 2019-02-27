using System;
using System.CodeDom;
using System.Collections;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            //#region Login
            //bool isLogIn = Opg1();

            //if (!isLogIn)
            //{
            //    return;
            //} 
            //PauseAndClear();
            //#endregion

            // Opg2And3();
            //PauseAndClear();

            float[,] punctuations = new float[10, 10];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Enter the punctuation {0} group {1}: ", j + 1, i + 1);
                    punctuations[i, j] = Convert.ToSingle(Console.ReadLine());
                }
            }
            PauseAndClear();
            for (int i = 0; i < 2; i++)
            {
                float avg = 0;
                for (int j = 0; j < 10; j++)
                {
                  avg += punctuations[i, j];
                }

                Console.WriteLine($"Average in punctuation {i+1}: {avg / 10}");
            }

        }
        
        private static void PauseAndClear()
        {
            Console.WriteLine("Press any Button to Continue");
            Console.ReadKey(true);
            Console.Clear();
        }
        private static void Opg2And3()
        {
            string[] boysName = new string[20]
            {
                "William", "Oliver", "Noah", "Emil", "Victor", "Magnus", "Frederik", "Mikkel", "Lucas", "Alexander", "Oscar",
                "Mathias", "Sebastian", "Malthe", "Elias", "Christian", "Mads", "Gustav", "Villads", "Tobias"
            };
            string[] girlName = new string [20]
            {
                "Ann", "Helle", "Aloha", "Fe", "Gift", "Mynte", "Myrtille", "Krushbakht", "Rikkepippih", "Lisa", "Yrsavickie",
                "Lise", "Tigerlilly", "Ninja", "Musling", "Jytta", "Europa", "Altan", "Lilly", "Josephine"
            };

            ArrayList nameArrayList = new ArrayList();
            nameArrayList.AddRange(Opg2(boysName));
            
          
            Opg3(nameArrayList, girlName);
        }

        private static void Opg3(ArrayList nameArrayList, string[] girlName)
        {
           
            bool stop = false;
            do
            {
                PauseAndClear();
                Console.WriteLine("Opg3 Delete Username From List");
                Console.WriteLine("Press 1 for Delete Name");
                Console.WriteLine("Press 2 for Add Name");
                Console.WriteLine("Press 3 to add Women Names");
                Console.WriteLine("press anything else to continue");
                char inputFromUser = Console.ReadKey(true).KeyChar;
                switch (inputFromUser)
                {
                    case '1':
                        nameArrayList = DeleteNameFromOpg3(nameArrayList);
                        break;
                    case '2':
                        nameArrayList = AddNameFromOpg3(nameArrayList);
                        break;
                    case '3':
                        nameArrayList.AddRange(girlName);

                        foreach (object o in nameArrayList)
                        {
                            Console.WriteLine(o);
                        }

                        break;
                    default:
                        stop = true;
                        break;
                }
            } while (!stop);
        }

        /// <summary>
        ///
        /// denne opgave indholder 20 drengenavne som bliver udskrevet i alfabetisk orden og kan søges via bokstaver fra inPutFromUser
        /// 
        /// BoysNames = boysname.orderBy(i = objected i Boysname fx "Noah" => i )
        /// .where( x = objected i Boysname fx "Noah" => x.ToLower() laver alt til lowerCaces. Contains kigger efter ( inPutFromUser )).ToArray(); putter tingene i et array.
        /// </summary>
        /// <param name="boysName"></param>
        private static string[] Opg2(string[] boysName)
        {
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