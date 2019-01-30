using System;

namespace Lotto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] lottoArray = new int[7];
            int[] kuponArray = new int[7];
            Random r = new Random();

            for (int i = 0; i < lottoArray.Length; i++)
            {
                int ran = r.Next(1, 20);
                lottoArray[i] = ran;

            }

            for (int i = 0; i < lottoArray.Length; i++)
            {
                for (int j = 0; j < lottoArray.Length - 1; j++)
                {
                    if (lottoArray[j] < lottoArray[j + 1])
                    {
                        continue;
                    }

                    int temp = lottoArray[j];
                    lottoArray[j] = lottoArray[j + 1];
                    lottoArray[j + 1] = temp;
                }
            }

            for (int i = 0; i < kuponArray.Length; i++)
            {
                int ran = r.Next(1, 20);
                kuponArray[i] = ran;

            }

            for (int i = 0; i < kuponArray.Length; i++)
            {
                for (int j = 0; j < kuponArray.Length - 1; j++)
                {
                    if (kuponArray[j] < kuponArray[j + 1])
                    { }
                    else
                    {
                        int temp1 = kuponArray[j];
                        kuponArray[j] = kuponArray[j + 1];
                        kuponArray[j + 1] = temp1;
                    }
                }
            }

            Console.WriteLine("The lotto numbers that was drawn is:\n ");
            foreach (int int32 in lottoArray)
            {
                Console.WriteLine(int32);
            }

            Console.WriteLine();

            Console.WriteLine("Your kupon numbers is:\n ");
            foreach (int int32 in kuponArray)
            {
                Console.WriteLine(int32);
            }

            int correctNumbers = 0;
            foreach (int k in kuponArray)
            {
                foreach (int l in lottoArray)
                {
                    if (k == l)
                    {
                        correctNumbers++;
                        break;
                    }
                }
            }

            Console.WriteLine();
            int prize = 0;
            switch (correctNumbers)
            {
                case 3:
                    prize = 125;
                    break;
                case 4:
                    prize = 250;
                    break;
                case 5:
                    prize = 1250;
                    break;
                case 6:
                    prize = 22500;
                    break;
                case 7:
                    prize = 6000000;
                    break;
                default:
                    Console.WriteLine("To bad you did not win anything, Try again next week.");
                    break;
            }

            if (prize > 0)
            {
                Console.WriteLine($"Hurray you did win {prize}kr.");
            }
        }
    }
}