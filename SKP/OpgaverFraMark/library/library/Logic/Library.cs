using library.Dal;

namespace library.Logic
{
    public class Library
    {
        Container container = new Container();

        public string CreateBooks(string author, string title, string genre, int pages)
        {
            container.Hylde.Add(new Book($"{author}, {title}, {genre}, {pages}"));
            

            return "Book is now Created";
        }

        public void PrintBookList()
        {
            //return PrintBookList();
        }




    }
}
