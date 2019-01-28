using System;
using System.Collections.Generic;

namespace Liste
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 20; i++) numbers.Add(i);


            Console.WriteLine(numbers);
        }
    }
}