using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace aTripToTheLibraryV._2
{
    public class Book
    {
        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _genre;
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        private int _pages;
        public int Pages
        {
            get { return _pages; }
            set { _pages = value; }
        }

        public Book(string author, string title, string genre, int pages)
        {
            Author = author;
            Title = title;
            Genre = genre;
            Pages = pages;

        }
    }
}
