using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int res = 1;

            Console.Write("intast tal: ");

            String str = Console.ReadLine();
            int i = Int32.Parse(str);

            for (j = i; j >= 1; j--)
            {
                res = res * j;
            }

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
