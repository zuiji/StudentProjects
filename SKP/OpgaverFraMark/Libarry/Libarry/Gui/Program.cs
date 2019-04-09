using System;
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

            //printing all titles out
            Console.WriteLine(library.PrintAllTitles());
           
            //calling CreateNewBook Method
            CreateNewBook(library);
            
            //Printing all titles out
            Console.WriteLine(library.PrintAllTitles());
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

            library.AddNewBook(new Book(author,title,genre));
            
          
        }
    }
}
