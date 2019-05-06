﻿using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayVariableAndRandom

            int correctNumber = 0;
            int prize = 0;
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

            Console.WriteLine();
            #endregion

            #region TypesOutToUser
            Console.WriteLine("The lottery numbers:\n ");
            foreach (int i in lottoArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.WriteLine("Your coupon numbers:\n ");
            foreach (int k in couponArray)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine();
            #endregion

            #region CouponAndLottoNumbersChecker
            foreach (int c in couponArray)
            {
                foreach (int l in lottoArray)
                {
                    if (c == l)
                    {
                        correctNumber++;
                        break;
                    }
                }
            }
            Console.WriteLine(); 
            #endregion

            #region Prize
            switch (correctNumber)
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
            #endregion
        }
    }
}