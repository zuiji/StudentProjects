using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterToMySelf
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Today;
            string name = "peter stubberup";
            string gade = "åvej 1";
            string by = "4632 Bjæverskov";
            string email = "Peter.stubberup@gmail.com";
           
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("|" +  ("Date: ").PadLeft(52) + $"{date.ToString("dd-MM-yy")}"+ " |");
            Console.WriteLine("|" +("").PadLeft(60)+                                       " |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|"+ $"{gade.PadLeft(60)}"+                                  " |");
            Console.WriteLine("|"+$"{by.PadLeft(60)}" +                                    " |");
            Console.WriteLine("|" + ("").PadLeft(60) +                                     " |");
            Console.WriteLine("|"+$"{email.PadLeft(60)}" +                                 " |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("---------------------------------------------------------------");


        }
    }
}
