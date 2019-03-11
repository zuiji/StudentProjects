using System;
using System.Collections.Generic;

namespace playWithPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> PrimeNumbers = new Queue<int>();
            PrimeNumbers.Enqueue(2);
            PrimeNumbers.Enqueue(3);
            PrimeNumbers.Enqueue(5);
            PrimeNumbers.Enqueue(7);
            PrimeNumbers.Enqueue(11);

            int total = 0;

            // Running each Queue truth the Queue PrimeNumber
            foreach (int number in PrimeNumbers)
            {
                Console.WriteLine($"primeNumber: {number}");
            }

            //new line for better look out
            Console.WriteLine("");

            // counting all the primes total there is in Queue and removing them from the Queue list. 
            while (PrimeNumbers.Count != 0)
            {
                total += PrimeNumbers.Dequeue();
            }
            // prints out the total amount of the Queue
            Console.WriteLine("total: " + total);


        }
    }
}
