using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lotto
{
    class NumberGenerator
    {

        #region GeneratsRandomnumbersToLottoArrayAndSorting
        public static int[] Generator()
        {
            Random random = new Random();
            // Generate numbers for LottoArray and Sorting it.
            int[] lottoArray = new int[7];
           
            for (int i = 0; i < lottoArray.Length; i++)
            {
                int ran = random.Next(1, 48);
                foreach (int i1 in lottoArray[i])
                {
                  
                }
            }

            Array.Sort(lottoArray);
            return lottoArray;


        }
        #endregion

    }

}
