using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    class Program
    {
        static void Main(string[] args)
        {
           CreateFile();
        }

        private static void CreateFile()
        {
            File.WriteAllText($@"C:\Users\pete646a\Desktop\GuestBook.txt", "IceCream");
        }
    }
}
