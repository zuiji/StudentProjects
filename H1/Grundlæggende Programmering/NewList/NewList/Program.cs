using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                numbers.Add(i);

                if (i % 3 == 0)
                {
                    numbers.Remove(i);

                }

                if (i == 17)
                {
                    numbers.Add(3);
                }
            }


            Console.WriteLine(numbers);


        }
    }
}
