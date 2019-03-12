using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace aTripToTheLibrary
{
    public class Book
    {
        // property
        #region Property

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _genrer;
        public string Genrer
        {
            get { return _genrer; }
            set { _genrer = value; }
        }

        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        private string _publisher;
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        private int _page;
        public int Page
        {
            get { return _page; }
            set { _page = value; }
        }

        private int _releaceYear;
        public int ReleaseYear
        {
            get { return _releaceYear; }
            set { _releaceYear = value; }
        }

        private bool _isSerie;
        public bool IsSerie
        {
            get { return _isSerie; }
            set { _isSerie = value; }
        }

        #endregion

        //constructor
        public Book()
        {

        }


        // the list we can add books too
        #region listOfBooks

        private static List<Book> books = new List<Book>
        {
            new Book("Harry Potter", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true),
            new Book("Harry Potter 2", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true),
            new Book("Harry Potter 3", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true),
            new Book("Harry Potter 4", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true),
            new Book("Harry Potter 5", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true),
            new Book("Harry Potter 6", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true),
            new Book("Harry Potter 7", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true),
            new Book("Harry Potter 8", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true),
            new Book("Lord Of the rings", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true),
            new Book("Lord Of the rings", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true),
            new Book("Lord Of the rings", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true),
            new Book("Percy jackson", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true),
            new Book("Percy jackson 2", "fantasi", "j.k roling", "hunkeboller", 508, 2018, true)
        };
        #endregion

        // stack list of borrowedBooks
        static Stack<Book> borrowedBooks = new Stack<Book>();

        //uses for references
        public static List<Book> Books
        {
            get { return new List<Book>(books); }
            set {books = value;}
        }
        //uses for references
        public static Stack<Book> BorrowedBooks
        {
            get {return borrowedBooks;}
            set {borrowedBooks = value;}
        }

        //uses for references
        public Book(string name, string genrer, string author, string publisher, int page, int releaceYear, bool isSerie)
        {
            _name = name;
            _genrer = genrer;
            _author = author;
            _publisher = publisher;
            _page = page;
            _releaceYear = releaceYear;
            _isSerie = isSerie;
        }

       
    }
}


