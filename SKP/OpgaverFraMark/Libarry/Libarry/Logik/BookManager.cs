﻿using System;
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
    }
}
