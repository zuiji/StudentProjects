using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                @"==================================================
            H1 Queue Operations Menu
==================================================
1. Add items

2. Delete items

3. Show the number of items

4. Show min and max items

5. Find an item

6. Print all items

7. Exit

Enter your choice:
");

            char inputFromUser = Console.ReadKey(true).KeyChar;
            bool fifo = true;
            switch (inputFromUser)
            {
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                case '5':
                    break;
                case '6':
                    break;
                case '7':
                    fifo = false;
                    break;
            }

        }
        private 
    }
}
