namespace PortoBeregner
{
    class Post
    {
        public int PType { get; set; }

        public int Weight { get; set; }

        public int Countrytype { get; set; }
       // public int Type { get; internal set; }

        public decimal getprice()
        {
            if (PType == 0)
                return getpriceletter();
            else
                return getpricepackage();

        }
        private decimal getpriceletter()
        {
            if (Countrytype == 0)
                return LetterPrices.denmarkletterprice(Weight);
            else
                return LetterPrices.outerletterprice(Weight);
        }
        private decimal getpricepackage()
        {
            switch (Countrytype)
            {
                case 0:
                    return PackageLetterPrice.denmarkPackageprice(Weight);
                case 1:
                    return PackageLetterPrice.feagøPackageprice(Weight);
                case 2:
                    return PackageLetterPrice.GrøndlandPackageprice(Weight);
                case 3:
                    return PackageLetterPrice.Europe1Packageprice(Weight);
                case 4:
                    return PackageLetterPrice.Europe2Packageprice(Weight);
                case 5:
                    return PackageLetterPrice.OtherPackageprice(Weight);

            }
            return 0;
        }
    }
}
