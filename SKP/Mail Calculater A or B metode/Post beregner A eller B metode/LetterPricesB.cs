using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_beregner_A_eller_B_metode
{
    class LetterPricesB
    {
        public static decimal denmarkletterpriceB(int weight)
        {
            decimal[] price = new decimal[] { (decimal)7.00, (decimal)14.00, (decimal)24.00, (decimal)33.00, (decimal)44.00, (decimal)55.00 };
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

        public static decimal europafæroernegrønlandletterpriceB(int weight)
        {
            decimal[] price = new decimal[] { (decimal)12.50, (decimal)24.00, (decimal)33.00, (decimal)51.00, (decimal)80.00, (decimal)120.00 };
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

        public static decimal othercontryesB(int weight)
        {
            decimal[] price = new decimal[]
            {
                (decimal) 15.00, (decimal) 30.00, (decimal) 51.00, (decimal) 73.00, (decimal) 120.00, (decimal) 180.00
            };
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
