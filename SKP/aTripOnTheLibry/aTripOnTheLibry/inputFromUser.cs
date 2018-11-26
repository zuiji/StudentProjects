using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace aTripOnTheLibry
{
    class inputFromUser
    {
        public static void
             RuninputFromUser()
        {
            char inputFromUser;
            do
            {
                Console.WriteLine("Hello " + System.Environment.UserName + "\nWelcome to The libery.\nHow can can we help?");
                Console.WriteLine("Please use 1 for see the list of Books, 2 for lend a Book, 3 for return a book, 4 to stop.");
                inputFromUser = Console.ReadKey(true).KeyChar;
                //Console.Clear();

                switch (inputFromUser)
                {
                    case '1':
                        Books.Bookslist();
                        Console.Clear();
                        break;
                    case '2':
                        Books.lendABook();
                        Console.Clear();
                        break;
                    case '3':
                        Books.ReturnABook();
                        Console.Clear();
                        break;
                    case '4':
                        Console.WriteLine("Have a good Time, Bye.");
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please Try agian 1 for booklist, 2 to lend a book, 3 return a book, 4 to stop.");
                        break;

                }
                
            } while (inputFromUser != '4');
            
        }
    }
}
