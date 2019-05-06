using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] LottoArray = new int[7];
            int[] kuponArray = new int[7];
            Random random = new Random();

            for (int i = 0; i < LottoArray.Length; i++)
            {
                int ran = random.Next(1, 48);
                LottoArray[i] = ran;
            }

            foreach (int i in LottoArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
