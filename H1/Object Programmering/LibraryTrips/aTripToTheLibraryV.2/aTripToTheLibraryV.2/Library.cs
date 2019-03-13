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
        //private List<Book> Books = new List<Book>();
        public List<Book> Books { get; private set; } = new List<Book>();

        // private Stack<Book> borrowedBookStack = new Stack<Book>();
        public Stack<Book> BorrowedBookStack { get; private set; } = new Stack<Book>();


        public void CreateBooks()
        {
            Book b1 = new Book("Jk.roling", "Harry Potter 1", "Fantasy", 800);
            Books.Add(b1);
            Book b2 = new Book("Jk.roling", "Harry Potter 2", "Fantasy", 800);
            Books.Add(b2);
            Book b3 = new Book("Jk.roling", "Harry Potter 3", "Fantasy", 800);
            Books.Add(b3);
            Book b4 = new Book("Jk.roling", "Harry Potter 4", "Fantasy", 800);
            Books.Add(b4);
        }

        /*public List<Book> ViewBookList()
        {
            return Books;
        }*/

        public Book PeekNextBookInStack()
        {
            return BorrowedBookStack.Peek();
        }

        public void AddBookToStack(int index)
        {
            // borrowedBookStack.Push(Books[1]);
            BorrowedBookStack.Push(Books[index]);
            Books.RemoveAt(index);
            //return borrowedBookStack;
        }

        public void ReturnBorrowedBook()
        {
            Books.Add(BorrowedBookStack.Pop());
        }

    }
}
