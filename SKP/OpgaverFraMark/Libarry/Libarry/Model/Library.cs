using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Logi
{

    public class Library
    {   
        //probertys
        public string Name { get; private set; }
        public string Address { get; private set; }

        // A way to store books ? 
        public List<Book> InventoryOfBooks { get; private set; }

        public Library(string name, string address)
        {
            Address = address;
            Name = name;
            InventoryOfBooks = new List<Book>();
        }

        // Hey i can't set new books because the list set is private!
        public void AddNewBook(Book book)
        {
            //aha
            InventoryOfBooks.Add(book); // Maybe i should make some logic that looks if the book already exists
        }


        //print loop to print all books out from the list
        public StringBuilder PrintAllTitles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("All Titles contained in the library: ");
            int num = 0;
            foreach (Book item in InventoryOfBooks)
            {
                sb.AppendLine(num + ": " + item.Title);
                num++;
            }
            return sb;
        }

        public void RemoveBookFromList(int i)
        {
            InventoryOfBooks.RemoveAt(i);
        }

    }

}