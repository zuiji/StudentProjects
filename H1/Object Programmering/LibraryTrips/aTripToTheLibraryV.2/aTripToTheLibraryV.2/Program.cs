using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aTripToTheLibraryV._2
{
    class Program
    {

        static void Main(string[] args)
        {
            Library myLibrary = new Library();
            myLibrary.CreateBooks();

            List<Book> temp = myLibrary.ViewBookList();
            foreach (Book book in temp)
            {
                Console.WriteLine($"Here is your List of books listed by title\n\n{myLibrary.ViewBookList().IndexOf(book)}\t{book.Title} ");
            }

           Stack<Book> tempStack = myLibrary.AddBookToStack();
           foreach (Book book in tempStack)
           {
               Console.WriteLine($"here is your Stack of Books listed by title\n\n{book.Title}");
           }

        }

    }
}
