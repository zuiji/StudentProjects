using System;
using System.Net;
using library.Logic;

namespace library.Gui
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What will you do\nPress { 1 } for Print all books out\nPress { 2 } to create new Book.");

            MainSwitchMenu();

        }



        private static void MainSwitchMenu()
        {
            char inputFromUser = Console.ReadKey(true).KeyChar; do
            {

                switch (inputFromUser)
                {
                    case '1':
                        do
                        {

                            Console.WriteLine(" Create Book");
                            Console.WriteLine(" ");
                            Console.WriteLine("Author");
                            string author = Console.ReadLine();
                            Console.WriteLine("Title ");
                            string title = Console.ReadLine();
                            Console.WriteLine("Genre");
                            string genre = Console.ReadLine();
                            Console.WriteLine("Pages");
                            int pages = int.Parse(Console.ReadLine());
                            Library.CreateBooks(author, title, genre, pages);
                            Console.WriteLine("press { 1 } to add another book");
                            
                            inputFromUser = Console.ReadKey(true).KeyChar;
                        } while (inputFromUser <= 1);
                        break;

                    case '2':
                        Library.PrintBookList(inputFromUser);
                        break;

                    case '3':
                        break;
                }
            } while (inputFromUser != 3);
        }

    }
}
