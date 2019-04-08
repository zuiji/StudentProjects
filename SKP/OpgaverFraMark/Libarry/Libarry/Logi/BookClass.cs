namespace Libarry
{
    class BookClass
    {
        public string Author { get; set;}
        public string Title { get; set;}
        public string Genre { get; set;}

        public BookClass(string author, string title, string genre)
        {
            author = Author;
            title = Title;
            genre = Genre;

        }

        public BookClass()
        {

        }
    }
}