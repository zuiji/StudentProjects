using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libarry.Logi;

namespace Libarry
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListOfBook bookList = new ListOfBook();
           // CreateBook(bookList);
            foreach (Book book in bookList.Biblotek)
            {
                Console.WriteLine(book.Title);
            }

            Book book1 = new Book("test" , "test", "test");

            Console.WriteLine(book1.Author);
            Console.WriteLine(book1.Title);
            Console.WriteLine(book1.Genre);


            Library library = new Library("My lownly library", "neverstreet 66");
            library.AddNewBook(book1);
            Console.WriteLine(library.PrintAllTitles());



        }

/*        private static void CreateBook(ListOfBook bookList)
        {
            Book book;
            book = new Book();
            Console.WriteLine("Insert Genre");
            book.Genre = Console.ReadLine();
            Console.WriteLine("insert Author");
            book.Author = Console.ReadLine();
            Console.WriteLine("insert Title");
            book.Title = Console.ReadLine();

            bookList.Biblotek.Add(book);
        }*/
    }
}
