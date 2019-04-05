using System;
using System.Net;
using library.Logic;

namespace library.Gui
{
    public class Program
    {
        Library lib = new Library();
        Book Book = new Book();
        void Main(string[] args)
        {
            Console.WriteLine("What will you do\nPress { 1 } for Print all books out\nPress { 2 } to create new Book.");
            char inputFromUser = Console.ReadKey(true).KeyChar;
            MainSwitchMenu(inputFromUser);

        }

        private void MainSwitchMenu(char inputFromUser)
        {
            throw new NotImplementedException();
        }

        private void MainSwitchMenu(char inputFromUser, string author, string title, string genre, int pages)
        {
            switch (inputFromUser)
            {
                case '1':
                    Console.WriteLine(" Create Book Author title genre pages ");
                    lib.CreateBooks(author, title,genre,pages);
                    break;
                case '2':
                    Console.WriteLine(" 2 ");
                    break;
            }
        }

        public void SubSwitchMenu(char inputFromUser)
        {
            switch (inputFromUser)
            {
                case '0':
                    Console.WriteLine("Return to Main Menu");
                    break;
                case '1':
                    Console.WriteLine("Add another Book");
                    break;
            }
        }
    }
}
