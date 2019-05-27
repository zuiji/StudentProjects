using System;
using System.Collections.Generic;
using System.Text;

namespace Lotto
{
    class NumberGenerator
    {
        #region GeneratsRandomnumbersToLottoArrayAndSorting
        public static int[] Generator(int[] lottoArray, Random random)
        { // Generate numbers for LottoArray and Sorting it.
           

            for (int i = 0; i < lottoArray.Length; i++)
            {
                int ran = random.Next(1, 48);
                lottoArray[i] = ran;

            }
            Array.Sort(lottoArray);
            return lottoArray;
            
        }
        #endregion
       
    }

}
