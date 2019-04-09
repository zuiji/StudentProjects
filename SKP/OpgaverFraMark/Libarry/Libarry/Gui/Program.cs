using System;
using System.Runtime.CompilerServices;
using Library.Logi;

namespace Library.Gui
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Test Book
            Book book = new Book("test", "test", "test");

            //test variables print
            Console.WriteLine(book.Author);
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Genre);

            //Library Creating and info
            Library.Logi.Library library = new Library.Logi.Library("My lowly library", "never-street 66");

            //adds new book
            library.AddNewBook(book);

            ////printing all titles out
            //Console.WriteLine(library.PrintAllTitles());


            MainMenuSwitch(library);
        }

        private static void MainMenuSwitch(Logi.Library library)
        {
            Console.WriteLine("press 1 to create book");
            Console.WriteLine("press 2 to Print all book titles out");
            Console.WriteLine("press 0 to Exit");

            char inputFromUser = Console.ReadKey(true).KeyChar;

            do
            {
                //switch case
                switch (inputFromUser)
                {
                    case '0':
                        break;

                    case '1':
                        //calling CreateNewBook Method
                        CreateNewBook(library);
                        break;

                    case '2':
                        //calling print all titles
                        Console.WriteLine(library.PrintAllTitles());
                        Program.MainMenuSwitch(library);
                        break;
                    default:
                        Console.WriteLine("non of your input does mach please try 0 - 2");
                        break;
                }

                inputFromUser = Console.ReadKey().KeyChar;
            } while (inputFromUser <= 0);
        }

        //user input to create new book
        private static void CreateNewBook(Library.Logi.Library library)
        {

            Console.WriteLine("Please add Author");
            string author = Console.ReadLine();
            Console.WriteLine("Please add Title");
            string title = Console.ReadLine();
            Console.WriteLine("Please add Genre");
            string genre = Console.ReadLine();

            library.AddNewBook(new Book(author, title, genre));

            Console.WriteLine("want to add another Book? ");
            Console.WriteLine("y for Add new book");
            char inputFromUser = Console.ReadKey(true).KeyChar;
            if (inputFromUser == 'Y' || inputFromUser == 'y')
            {
                Console.Clear();
                CreateNewBook(library);
            }
            else
            {
                Program.MainMenuSwitch(library);
            }
        }
    }
}
