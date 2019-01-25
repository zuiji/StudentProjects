namespace PortoBeregner
{
    class PackageLetterPrice
    {
        public static decimal denmarkPackageprice(int weight)
        {
            decimal[] price = new decimal[] { 80, 110, 170, 250, (decimal)312.50, 350 };
            if (weight <= 5)
                return price[0];
            if (weight <= 10)
                return price[1];
            if (weight <= 20)
                return price[2];
            if (weight <= 25)
                return price[3];
            if (weight <= 30)
                return price[4];
            if (weight <= 35)
                return price[5];
            else
                return -1;
        }

        public static decimal feagøPackageprice(int weight)
        {
            decimal[] price = new decimal[] { 194,222, 294,366,438 };
            if (weight <= 1)
                return price[0];
            if (weight <= 5)
                return price[1];
            if (weight <= 10)
                return price[1];
            if (weight <= 15)
                return price[1];
            if (weight <= 20)
                return price[1];
            else
                return -1;
        }
        public static decimal GrøndlandPackageprice(int weight)
        {
            decimal[] price = new decimal[] { 196, 248, 437, 559, 686 };
            if (weight <= 1)
                return price[0];
            if (weight <= 5)
                return price[1];
            if (weight <= 10)
                return price[1];
            if (weight <= 15)
                return price[1];
            if (weight <= 20)
                return price[1];
            else
                return -1;
        }

        public static decimal Europe2Packageprice(int weight)
        {
            decimal[] price = new decimal[] { 236, 315, 493, 638, 790 };
            if (weight <= 1)
                return price[0];
            if (weight <= 5)
                return price[1];
            if (weight <= 10)
                return price[1];
            if (weight <= 15)
                return price[1];
            if (weight <= 20)
                return price[1];
            else
                return -1;
        }
        public static decimal Europe1Packageprice(int weight)
        {
            decimal[] price = new decimal[] { 190, 275, 445, 530, 685 };
            if (weight <= 1)
                return price[0];
            if (weight <= 5)
                return price[1];
            if (weight <= 10)
                return price[1];
            if (weight <= 15)
                return price[1];
            if (weight <= 20)
                return price[1];
            else
                return -1;
        }
        public static decimal OtherPackageprice(int weight)
        {
            decimal[] price = new decimal[] { 275, 517, 840, 1244, 1648 };
            if (weight <= 1)
                return price[0];
            if (weight <= 5)
                return price[1];
            if (weight <= 10)
                return price[1];
            if (weight <= 15)
                return price[1];
            if (weight <= 20)
                return price[1];
            else
                return -1;
        }

    }
}
