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
            CreateBook(bookList);
            foreach (Book book in bookList.Biblotek)
            {
                Console.WriteLine(book.Title);
            }


        }
      


        private static void CreateBook(ListOfBook bookList)
        {
            Book book;
            book = new Book();
            book.Genre = Console.ReadLine();
            book.Author = Console.ReadLine();
            book.Title = Console.ReadLine();

            bookList.Biblotek.Add(book);
        }
    }
}
