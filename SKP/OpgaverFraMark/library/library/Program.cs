using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputFromUser = Console.ReadKey(true).KeyChar;

            switch (inputFromUser)
            {
                case '1':
                   library.PrintBookList(listOfBooks);
                    break;
                case '2':
                    break;
            }
        }
    }
}
