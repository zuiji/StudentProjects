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

            BorrowBooks(myLibrary);
            ReturnBooks(myLibrary);
           

        }

        private static void ReturnBooks(Library myLibrary)
        {
            char inputFromUser;

            do
            {
                if (!myLibrary.BorrowedBookStack.Any())
                {
                    Console.WriteLine("no more books to return");
                    break;
                }

                Console.WriteLine(myLibrary.PeekNextBookInStack().Title);
                myLibrary.ReturnBorrowedBook();
                Console.WriteLine("Press { 1 } more books?");
                inputFromUser = Console.ReadKey(true).KeyChar;
            } while (inputFromUser == '1');
        }

        private static void BorrowBooks(Library myLibrary)
        {
            char inputFromUser;
            do
            {
                Console.WriteLine("Here is your List of Books listed by title\n\n");
                foreach (Book book in myLibrary.Books)
                {
                   Console.WriteLine($"{myLibrary.Books.IndexOf(book)}\t{book.Title} ");
                }

                Console.WriteLine("what book do you want to borrow?");
                int index = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                myLibrary.AddBookToStack(index);
                Console.WriteLine(myLibrary.PeekNextBookInStack().Title);
                if (!myLibrary.Books.Any())
                {
                    Console.WriteLine("no more books to borrow");
                    break;
                }

                Console.WriteLine("Press { 1 } more books?");
                inputFromUser = Console.ReadKey(true).KeyChar;
            } while (inputFromUser == '1');
        }
    }
}
