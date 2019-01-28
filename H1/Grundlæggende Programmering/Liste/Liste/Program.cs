
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i <= 20; i++) 
            {
                numbers.Add(i);
                Console.WriteLine(numbers);

            }


            
        }
    }
}