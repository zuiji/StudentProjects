using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace aTripToTheLibraryV._2
{
    class Book
    {
        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string genre;
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        private int pages;
        public int Pages
        {
            get { return pages; }
            set { pages = value; }
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
