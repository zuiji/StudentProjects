using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_beregner_A_eller_B_metode
{
    class Post
    {
        public int Ptype { get; set;}
        public int Weight { get; set; }
        public int Contrytype { get; set; }

        public decimal getPrice()
        {
            if (Ptype == 0)
                return getpriceletter();
            else
                return getpriceletterB();
        }

        private decimal getpriceletter()
        {
            switch (Contrytype)
            {
                case 0:
                    return LetterPricesA.denmarkletterpriceA(Weight);
                case 1:
                    return LetterPricesA.europafæroernegrønlandletterpriceA(Weight);
                case 2:
                    return LetterPricesA.othercontryesA(Weight);
            }

            return 0;

        }

        private decimal getpriceletterB()
        {
            switch (Contrytype)
            {
                case 0:
                    return LetterPricesB.denmarkletterpriceB(Weight);
                case 1:
                    return LetterPricesB.europafæroernegrønlandletterpriceB(Weight);
                case 2:
                    return LetterPricesB.othercontryesB(Weight);

            }

            return 0;
        }
    }
    
   
}
