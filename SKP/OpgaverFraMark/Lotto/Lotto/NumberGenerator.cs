using System;
using System.Collections.Generic;
using System.Text;

namespace Lotto
{
    class NumberGenerator
    {
        // Generate numbers for LottoArray and Sorting it.
        #region GeneratsRandomnumbersToLottoArrayAndSorting
        public void Generator(int[] lottoArray, Random random)
        {
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
        }
        #endregion


        // Generate numbers for Coupon and sorting it.
        #region GenerateNumbersToCouponArrayAndSorting
        public void CouponGenerator(int[] couponArray, Random random)
        {
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

        }
        #endregion
    }
   
}
