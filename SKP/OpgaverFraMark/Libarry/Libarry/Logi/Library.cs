using System.Collections.Generic;
using System.Text;

namespace Libarry
{

    public class Library
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public List<Book> InventoryOfBooks { get; private set; }

        public Library(string name, string address)
        {
            Address = address;
            Name = name;
            InventoryOfBooks = new List<Book>();
        }

        public void AddNewBook(Book book)
        {
            InventoryOfBooks.Add(book);
        }

        public StringBuilder PrintAllTitles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("All Titles contained in the library: ");
            int num = 1;
            foreach (Book item in InventoryOfBooks)
            {
                sb.AppendLine(num + ": " + item.Title);
                num++;
            }

            return sb;
        }

    }

}