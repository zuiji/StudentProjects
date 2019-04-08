using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Libarry.Logi;

namespace Libarry
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("test", "test", "test");

            Console.WriteLine(book.Author);
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Genre);


            Library library = new Library("My lownly library", "never-street 66");
            library.AddNewBook(book);
            Console.WriteLine(library.PrintAllTitles());

            CreateBook(library);
        }

        private static void CreateBook(Library library)
        {
            Book book; 
            book = new Book();
            Console.WriteLine("Please add Author");
            book.Author = Console.ReadLine();
            Console.WriteLine("Please add Title");
            book.Title = Console.ReadLine();
            Console.WriteLine("Please add Genre");
            book.Genre = Console.ReadLine();

            library.InventoryOfBooks.Add(book);
          
        }
    }
}
