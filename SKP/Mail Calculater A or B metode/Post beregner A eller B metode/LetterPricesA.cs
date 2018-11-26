using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_beregner_A_eller_B_metode
{
    class LetterPricesA
    {
        public static decimal denmarkletterpriceA(int weight)
        {
            decimal[] price = new decimal[]{(decimal) 10.00,(decimal)19.00 , (decimal)30.00, (decimal)40.00,(decimal)51.00,(decimal)64.00};
            if (weight <= 50)
                return price[0];
            if (weight <= 100)
                return price[1];
            if (weight <= 250)
                return price[2];
            if (weight <= 500)
                return price[3];
            if (weight <= 1000)
                return price[4];
            if (weight <= 2000)
                return price[5];
            else
                return -1;

        }

        public static decimal europafæroernegrønlandletterpriceA(int weight)
        {
            decimal[] price = new decimal[]{ (decimal)14.50, (decimal)28.00, (decimal)38.00, (decimal)60.00, (decimal)90.00, (decimal)135.00};
            if (weight <= 50)
                return price[0];
            if (weight <= 100)
                return price[1];
            if (weight <= 250)
                return price[2];
            if (weight <= 500)
                return price[3];
            if (weight <= 1000)
                return price[4];
            if (weight <= 2000)
                return price[5];
            else
                return -1;
        }
        public static decimal othercontryesA(int weight)
        {
            decimal[] price = new decimal[] { (decimal)16.50, (decimal)33.00, (decimal)55.00, (decimal)80.00, (decimal)135.00, (decimal)200.00 };
            if (weight <= 50)
                return price[0];
            if (weight <= 100)
                return price[1];
            if (weight <= 250)
                return price[2];
            if (weight <= 500)
                return price[3];
            if (weight <= 1000)
                return price[4];
            if (weight <= 2000)
                return price[5];
            else
                return -1;
        }
    }
}
