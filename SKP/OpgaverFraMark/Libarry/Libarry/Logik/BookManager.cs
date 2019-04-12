using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

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

    }
}
