using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Logi;

namespace Libarry.Logik
{
    class BookManager
    {
        public Book CreateNewBook(Library.Logi.Library library ,string author, string title, string genre)
        {
            library.AddNewBook(new Book(author,title,genre));
            return new Book(author, title, genre);
        }
    }
}
