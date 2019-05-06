using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] LottoArray = new int[7];
            int[] CouponArray = new int[7];
            Random random = new Random();

            for (int i = 0; i < LottoArray.Length; i++)
            {
                int ran = random.Next(1, 48);
                LottoArray[i] = ran;
            }

            for (int k = 0; k < CouponArray.Length; k++)
            {
                int ran = random.Next(1, 48);
                CouponArray[k] = ran;
            }

            Console.WriteLine("The lottery numbers: ");
            foreach (int i in LottoArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Your coupon numbers: ");
            foreach (int k in CouponArray)
            {
                Console.WriteLine(k);
            }
        }
    }
}
