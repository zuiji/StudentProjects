using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarry
{
    class BookManager
    {
        public Book CreateNewBook(string author, string title, string genre)
        {
            return new Book(author, title, genre);
        }

        public string PrintBook(List<Book> ListInput)
        {
            string temp = "";
            foreach (Book book in ListInput)
            {
                temp += $"{book.Title}\n";
            }

            return temp;
        }

        public Book DeleteBook(string title, List<Book> listOutPut)
        {
           
            foreach (Book book in listOutPut)
            {
                if (book.Title == title)
                {
                    listOutPut.Remove(book);
                }

            }

            return listOutPut;
        }

    }
}
