using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;




namespace aTripToTheLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Library();
        }

        // running truth the list of books and writes out author title and index number
        static void CheckBooks()
        {
            foreach (Book item in Book.Books)
            {
                Console.WriteLine("Title: {0}\r\nAuthor: {1}\r\nIndex number: {2}\r\n", item.Name, item.Author, (Book.Books.IndexOf(item) + 1));
               
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }


        // borrowing the book out use user and push it to borrowedBooks by index number. 
        static void BorrowedBooks()
        {
            int bookNumber;
            Console.Write("What book do you want to borrow? Please input the shelf number: ");
            bookNumber = int.Parse(Console.ReadLine()) - 1;
            string book = Book.Books[bookNumber].Name;
            Console.WriteLine("you chose: {0}", book);
            Book.BorrowedBooks.Push((Book.Books[bookNumber]));
            Book.Books.RemoveAt(bookNumber);
            Console.ReadLine();

        }

        //retuner book looks on what book user have borrowed and if no books left user cant borrow any more books 
        static void ReturnBooks()
        {
            while (Book.BorrowedBooks.Count() != 0)
            {
                foreach (Book item in Book.BorrowedBooks)
                {
                    Console.WriteLine("My books: {0}", item.Name);
                }
                Book.Books.Add(Book.BorrowedBooks.Pop());
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }
        }

        // using this for user chooses. 
        static void Library()
        {
            
            bool inLibrary = true;

            do
            {

                Console.WriteLine("1: Check books");
                Console.WriteLine("2: Borrow books");
                Console.WriteLine("3: Return books");
                Console.WriteLine("4: Leave library");

                char inputFromUser = Console.ReadKey(true).KeyChar;
                switch (inputFromUser)
                {
                    case '1':
                        CheckBooks();
                        break;
                    case '2':
                        BorrowedBooks();
                        break;
                    case '3':
                        ReturnBooks();
                        break;
                    case '4':
                        inLibrary = false;
                        break;
                }
            } while (inLibrary);
        }
    }
}

