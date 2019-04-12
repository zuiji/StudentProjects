using Libarry;
using System;
using System.Text;

namespace Library
{
    class Program
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
            Library library = new Library("My lowly library", "never-street 66");
            BookManager bookManager = new BookManager();
            //adds new book
            library.AddNewBook(book);

            ////printing all titles out
            //Console.WriteLine(library.PrintAllTitles());


            MainMenuSwitch(library, bookManager);
        }

        //this method are used so user can choose what they want to do.
        private static void MainMenuSwitch(Library library, BookManager bookManager)
        {
            Console.Clear();
            Console.WriteLine("press 1 to Print all book titles out");
            Console.WriteLine("press 2 to create book");
            Console.WriteLine("press 3 to delete a book");
            Console.WriteLine("press 0 to Exit");
            Console.WriteLine("");

            char inputFromUser = Console.ReadKey(true).KeyChar;

            do
            {
                //switch case
                switch (inputFromUser)
                {
                    //breaks out of the switch
                    case '0':
                        return;
                        
                    case '1':
                        //calling print all titles
                        PrintAllTitle(library, bookManager);
                      break;

                    case '2':
                        //calling CreateNewBook Method
                        CreateNewBook(library, bookManager);
                        break;
                    case '3':
                        //calling print all titles
                        Console.WriteLine(library.PrintAllTitles());
                        //calls delete Book
                        library.RemoveBookFromList(int.Parse(Console.ReadLine()));

                        //calls back to mainmenuswitch method
                        Program.MainMenuSwitch(library, bookManager);
                        break;
                    default:
                        Console.WriteLine("non of your input does mach please try 0 - 3");
                        break;
                }

                inputFromUser = Console.ReadKey().KeyChar;
            } while (inputFromUser <= 0);
        }

        //user input to create new book
        private static void CreateNewBook(Library library, BookManager bookManager)
        {
            Console.WriteLine("Please add Author");
            string author = Console.ReadLine();
            Console.WriteLine("Please add Title");
            string title = Console.ReadLine();
            Console.WriteLine("Please add Genre");
            string genre = Console.ReadLine();
            library.AddNewBook(bookManager.CreateNewBook(author, title, genre)); 
            
            Console.WriteLine("want to add another Book? ");
            Console.WriteLine("Press Y for Add new book");
            char inputFromUser = Console.ReadKey(true).KeyChar;
            if (char.ToUpper(inputFromUser) =='Y')
            {
                Console.Clear();
                CreateNewBook(library,bookManager);
            }
            else
            {

                // return to mainmenuswitch method
                Program.MainMenuSwitch(library, bookManager);
            }
        }
        
        private static void PrintAllTitle(Library library, BookManager bookManager)
        {
            Console.WriteLine(bookManager.PrintBook(library.InventoryOfBooks));
            Console.WriteLine("Press Y to go back to mainmenu");
            char inputFromUser = Console.ReadKey(true).KeyChar;
            if (char.ToUpper(inputFromUser) == 'Y')
            {
                Console.Clear();
                MainMenuSwitch(library, bookManager);

            }
            else
            {
                return;
            }

        }
    }
}
