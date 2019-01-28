namespace PortoBeregner
{
    public static class LetterPrices
    {
        public static decimal denmarkletterprice(int weight)
        {
            decimal[] price = new decimal[] { (decimal)9.00, (decimal)18.00, (decimal)36.00, (decimal)45.00, (decimal)54.00 };
            if (weight <= 50)
                return price[0];
            if (weight <= 100)
                return price[1];
            if (weight <= 250)
                return price[2];
            if (weight <= 500)
                return price[3];
            else
                return price[4];
        }

        public static decimal outerletterprice(int weight)
        {
            decimal[] price = new decimal[] { (decimal)27.00, (decimal)54.00 , (decimal)108.00 };
            if (weight <= 100)
                return price[0];
            if (weight <= 500)
                return price[1];
            else
                return price[2];
        }
    }
}
