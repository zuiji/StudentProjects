using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aTripToTheLibraryV._2
{
    public class Library
    {
        private List<Book> books = new List<Book>();


        Stack<Book> borrowedBookStack = new Stack<Book>();



        public void CreateBooks()
        {
            Book b1 = new Book("Jk.roling", "Harry Potter1", "Fantasy", 800);
            books.Add(b1);
            Book b2 = new Book("Jk.roling", "Harry Potter2", "Fantasy", 800);
            books.Add(b2);
            Book b3 = new Book("Jk.roling", "Harry Potter3", "Fantasy", 800);
            books.Add(b3);
            Book b4 = new Book("Jk.roling", "Harry Potter4", "Fantasy", 800);
            books.Add(b4);
        }

        public List<Book> ViewBookList()
        {
            return books;
        }

        public  Stack<Book> AddBookToStack()
        {
            borrowedBookStack.Push(books[1]);
            return borrowedBookStack;
        }
    }
}
