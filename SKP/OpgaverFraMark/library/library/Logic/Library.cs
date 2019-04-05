using System;
using System.Runtime.Remoting.Messaging;
using library.Dal;
using library.Gui;

namespace library.Logic
{
    public class Library
    {
       

        public static string CreateBooks(string author, string title, string genre, int pages)
        {

            Container.Hylde.Add(new Book(author, title, genre, pages));


            return "Book is now Created";

        }

        public static void PrintBookList(char inputFromUser)
        {
           
                foreach (Book book in Container.Hylde)
                {
                    Console.WriteLine($"Title: {0}\r\nAuthor: {1}\r\nIndex number: {2}\r\n", book.Title, book.Author, (Container.Hylde.IndexOf(book) + 1));
                } 
               
            
        }
        
    }
}
