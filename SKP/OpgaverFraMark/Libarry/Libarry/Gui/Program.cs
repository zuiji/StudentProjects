using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


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


            Library library = new Library("My lowly library", "never-street 66");
            library.AddNewBook(book);
            Console.WriteLine(library.PrintAllTitles());

            CreateNewBook(library);

            Console.WriteLine(library.PrintAllTitles());
        }

        private static void CreateNewBook(Library library)
        {
            Book book;
            Console.WriteLine("Please add Author");
            string author = Console.ReadLine();
            Console.WriteLine("Please add Title");
            string title = Console.ReadLine();
            Console.WriteLine("Please add Genre");
            string genre = Console.ReadLine();
            
            book = new Book(author,title,genre);
            library.AddNewBook(book);
          
        }
    }
}
