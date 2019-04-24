namespace Libarry
{
    public class Book
    {
        //property
        public string Author { get; private set; }
        public string Title { get; private set; }
        public string Genre { get; private set; }
        

        //constructor with variables
        public Book(string author, string title, string genre)
        {
            Author = author;
            Title = title;
            Genre = genre;
        }


        //empty constructor
        public Book()
        {

        }
    }
}