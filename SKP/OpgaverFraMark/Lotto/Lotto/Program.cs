using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArraysAndRandom
            int[] lottoArray = new int[7];
            int[] couponArray = new int[7];
            Random random = new Random();
            #endregion


            #region GeneratsRandomnumbersToLottoArrayAndSorting
            for (int i = 0; i < lottoArray.Length; i++)
            {
                int ran = random.Next(1, 48);
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

            #endregion

            #region GenerateNumbersToCouponArrayAndSorting
            for (int k = 0; k < couponArray.Length; k++)
            {
                int ran = random.Next(1, 48);
                couponArray[k] = ran;
            }

            for (int i = 0; i < couponArray.Length; i++)
            {
                for (int j = 0; j < couponArray.Length - 1; j++)
                {
                    if (couponArray[j] < couponArray[j + 1])
                    {
                        continue;
                    }

                    int temp = couponArray[j];
                    couponArray[j] = couponArray[j + 1];
                    couponArray[j + 1] = temp;
                }
            }

            #endregion



            #region TypesOutToUser
            Console.WriteLine("The lottery numbers: ");
            foreach (int i in lottoArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Your coupon numbers: ");
            foreach (int k in couponArray)
            {
                Console.WriteLine(k);
            }
            #endregion
        }
    }
}
